﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scanner.Model;
using Scanner.BLL;
using System.Reflection;

namespace Scanner
{
    partial class MainForm
    {
        /// <summary>
        /// 初始化方法
        /// </summary>
        public void Init()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                m_controls.Add(c);
            }
            scanner.OnScanProgress += OnScanProgress;
            scanner.OnScanPortComplete += OnScanPortComplete;
            scanner.OnScanedCanConnect += (portInfo) =>
            {
                if (list_CanUsePortList.InvokeRequired)
                {
                    list_CanUsePortList.Invoke(new Action<PortInfo>((port) => { list_CanUsePortList.Items.Add(port); }), portInfo);
                }
                else
                {
                    list_CanUsePortList.Items.Add(portInfo);
                }
            };

            txtBox_MaxThreadPool.LostFocus += (o, e) =>
            {
                TextBox t = o as TextBox;
                bool parseResult = false;
                int maxThread;
                parseResult = int.TryParse(t.Text, out maxThread);
                if (parseResult)
                {
                    if (maxThread >= 20 && maxThread <= 150)
                    {
                        t.Text = maxThread.ToString();
                    }
                    else
                    {
                        t.Text = "20";
                    }
                }
                else
                {
                    t.Text = "20";
                }
            };

            txt_portFrom.LostFocus += (o, e) =>
            {
                try
                {
                    OnValidatePortInput(o, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    TextBox t = o as TextBox;
                    t.Focus();
                }
            };

            txt_portEnd.LostFocus += (o, e) =>
            {
                try
                {
                    OnValidatePortInput(o, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    TextBox t = o as TextBox;
                    t.Focus();
                }
            };
            SetUIStatus(WorkStatus.Init);
        }
        /// <summary>
        /// 将UI的可交互性设置为指定的程序状态下的状态
        /// </summary>
        /// <param name="status">当前程序所处的状态</param>
        private void SetUIStatus(WorkStatus status)
        {
            Type type = status.GetType();
            FieldInfo filed = type.GetField(status.ToString());
            if (filed != null)
            {
                object[] bindedAttribute = filed.GetCustomAttributes(typeof(WorkStatusAttribute), true);
                foreach (var attr in bindedAttribute)
                {
                    WorkStatusAttribute w = attr as WorkStatusAttribute;
                    if (w != null)
                    {
                        w.Controls = m_controls;
                        w.SetStatusUI();
                    }
                }
            }
        }
    }
}
