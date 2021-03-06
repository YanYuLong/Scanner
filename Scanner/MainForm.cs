﻿using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scanner.Model;
using Scanner.BLL;


namespace Scanner
{
    public partial class MainForm : Form
    {
        #region Filed
        List<Control> m_controls = new List<Control>();
        Scanner.BLL.Scanner scanner = new Scanner.BLL.Scanner();
        int m_StartPort = 1;
        int m_EndPort = 65535;
        #endregion

        public MainForm()
        {
            Init();
        }
        //开始扫描
        private void btn_StartScan_Click(object sender, EventArgs e)
        {
            string domain = txtBox_ScannerInput.Text;
            SetMaxThread();
            if (!string.IsNullOrEmpty(domain))
            {
                SetUIStatus(WorkStatus.Scan);
                try
                {
                    scanner.Domain = domain;
                    scanner.Scanning();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    SetUIStatus(WorkStatus.Init);
                }
            }
            else
            {
                MessageBox.Show("请输入要扫描的domain");
            }
        }
        //逻辑层扫描事件处理器
        private void OnScanProgress(int pg)
        {
            if (pg_ScannerPg.InvokeRequired)
            {
                pg_ScannerPg.Invoke(new Action<int>((t) => { pg_ScannerPg.Value = (int)(((pg / (m_EndPort - m_StartPort * 1.0)) * 100)); }), pg);
            }
            else
            {
                pg_ScannerPg.Value = (int)(((pg / (m_EndPort - m_StartPort * 1.0)) * 100));
            }
            if (lbl_ScannerPort.InvokeRequired)
            {
                lbl_ScannerPort.Invoke(new Action<int>((t) => { lbl_ScannerPort.Text = pg.ToString(); }), pg);
            }
            else
            {
                lbl_ScannerPort.Text = pg.ToString();
            }
            if (lbl_SannerPercent.InvokeRequired)
            {
                lbl_SannerPercent.Invoke(new Action<int>((t) => { lbl_SannerPercent.Text = ((t / (m_EndPort - m_StartPort * 1.0)) * 100).ToString("F2") + "%"; }), pg);
            }
            else
            {
                lbl_SannerPercent.Text = ((pg / (m_EndPort - m_StartPort * 1.0)) * 100).ToString("F2") + "%";
            }
        }
        // 逻辑层扫描完成事件处理器
        private void OnScanPortComplete(List<PortInfo> info)
        {
            SetUIStatus(WorkStatus.ScanComplete);
        }
        // 验证输入的端口数据事件处理器
        private void OnValidatePortInput(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t != null)
            {
                try
                {
                    int outer = 0;
                    bool parseResult = int.TryParse(t.Text, out outer);
                    if (parseResult)
                    {
                        if (t.Name == "txt_portFrom")
                        {
                            scanner.StartPort = outer;
                            m_StartPort = outer;
                        }
                        else
                        {
                            scanner.EndPort = outer;
                            m_EndPort = outer;
                        }
                    }
                    else
                    {
                        throw new Exception("输入的端口非法");
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }
        //发送数据按钮 
        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (list_CanUsePortList.SelectedItem == null)
            {
                MessageBox.Show("请先选择要发送的端口号");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_UseEncoding.Text))
            {
                MessageBox.Show("请输入要使用的发送数据的编码格式");
                return;
            }
            if (string.IsNullOrWhiteSpace(richTxt_SendingInfo.Text))
            {
                MessageBox.Show("请输入要发送的数据");
                return;
            }
            SendData sendHelper = new SendData();
            sendHelper.Encoding = txt_UseEncoding.Text;
            sendHelper.IP = txtBox_ScannerInput.Text;
            sendHelper.Port = (list_CanUsePortList.SelectedItem as PortInfo).Port;
            sendHelper.TimeOut = 10;
            lbl_ReciveStatus.Text = "正在接收数据....";
            sendHelper.OnTimeOut += (i) =>
            {
                MessageBox.Show("接收超时了！！请检查您的输入和选用的编码是否有误");
                lbl_ReciveStatus.Text = "接收超时了";
            };

            sendHelper.AsyncGetResult(new Action<object>((o) =>
            {
                byte[] result = o as byte[];
                if (result != null)
                {
                    if (lbl_ReciveStatus.InvokeRequired)
                    {
                        lbl_ReciveStatus.Invoke(new Action<object>((obj) => { lbl_ReciveStatus.Text = "接收完成"; }), result);
                    }
                    else
                    {
                        lbl_ReciveStatus.Text = "接收完成 ";
                    }
                    string resultMsg = Encoding.UTF8.GetString(result);
                    MessageBox.Show(resultMsg);
                }
            }), richTxt_SendingInfo.Text);
        }
        //重新扫描按钮
        private void btn_ReScan_Click(object sender, EventArgs e)
        {
            list_CanUsePortList.Items.Clear();
            txtBox_ScannerInput.Text = string.Empty;
            txt_portFrom.Text = "1";
            txt_portEnd.Text = "65535";
            pg_ScannerPg.Value = 0;
            lbl_ScannerPort.Text = string.Empty;
            lbl_SannerPercent.Text = "%";
            SetUIStatus(WorkStatus.Init);
        }

        private void ListSelectChange(object o, EventArgs e)
        {
            Model.PortInfo SelectInfo = list_CanUsePortList.SelectedItem as Model.PortInfo;
            if (SelectInfo != null)
            {
                lbl_SelectPort.Text = SelectInfo.Port.ToString();
            }
        }
        private void Txt_UseEncoding_LostFocus(object sender, System.EventArgs e)
        {
            string UserInput = txt_UseEncoding.Text;
            if (!string.IsNullOrWhiteSpace(UserInput))
            {
                bool EncodeTestResult = SendData.IsCanUseEncode(UserInput);
                if (!EncodeTestResult)
                {
                    MessageBox.Show("请输入系统支持的编码格式");
                    txt_UseEncoding.Text = string.Empty;
                }
            }
        }
        private void SetMaxThread()
        {
            int maxThread = 0;
            bool parseResult = int.TryParse(txtBox_MaxThreadPool.Text, out maxThread);
            if (parseResult)
            {
                System.Threading.ThreadPool.SetMaxThreads(maxThread, maxThread);
            }
            else
            {
                MessageBox.Show("最大线程数量设置转换异常");
            }
        }
    }
}
