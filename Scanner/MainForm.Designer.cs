﻿namespace Scanner
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_SannerInput = new System.Windows.Forms.Label();
            this.txtBox_ScannerInput = new System.Windows.Forms.TextBox();
            this.pg_ScannerPg = new System.Windows.Forms.ProgressBar();
            this.lbl_SannerPercent = new System.Windows.Forms.Label();
            this.lbl_ScannerPort = new System.Windows.Forms.Label();
            this.list_CanUsePortList = new System.Windows.Forms.ListBox();
            this.richTxt_SendingInfo = new System.Windows.Forms.RichTextBox();
            this.btn_StartScan = new System.Windows.Forms.Button();
            this.lbl_SelectPort = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_UseEncoding = new System.Windows.Forms.TextBox();
            this.lbl_SendEncoding = new System.Windows.Forms.Label();
            this.txt_portFrom = new System.Windows.Forms.TextBox();
            this.lbl_Spliter = new System.Windows.Forms.Label();
            this.txt_portEnd = new System.Windows.Forms.TextBox();
            this.btn_ReScan = new System.Windows.Forms.Button();
            this.lbl_ReciveStatus = new System.Windows.Forms.Label();
            this.txtBox_MaxThreadPool = new System.Windows.Forms.TextBox();
            this.lbl_MaxThread = new System.Windows.Forms.Label();
            this.toolTip_MaxThread = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbl_SannerInput
            // 
            this.lbl_SannerInput.AutoSize = true;
            this.lbl_SannerInput.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SannerInput.Location = new System.Drawing.Point(39, 40);
            this.lbl_SannerInput.Name = "lbl_SannerInput";
            this.lbl_SannerInput.Size = new System.Drawing.Size(193, 20);
            this.lbl_SannerInput.TabIndex = 0;
            this.lbl_SannerInput.Text = "请输入要扫描的域名或IP地址:";
            // 
            // txtBox_ScannerInput
            // 
            this.txtBox_ScannerInput.Location = new System.Drawing.Point(245, 41);
            this.txtBox_ScannerInput.Name = "txtBox_ScannerInput";
            this.txtBox_ScannerInput.Size = new System.Drawing.Size(209, 21);
            this.txtBox_ScannerInput.TabIndex = 1;
            // 
            // pg_ScannerPg
            // 
            this.pg_ScannerPg.Location = new System.Drawing.Point(43, 100);
            this.pg_ScannerPg.Name = "pg_ScannerPg";
            this.pg_ScannerPg.Size = new System.Drawing.Size(411, 23);
            this.pg_ScannerPg.TabIndex = 2;
            // 
            // lbl_SannerPercent
            // 
            this.lbl_SannerPercent.AutoSize = true;
            this.lbl_SannerPercent.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SannerPercent.Location = new System.Drawing.Point(689, 103);
            this.lbl_SannerPercent.Name = "lbl_SannerPercent";
            this.lbl_SannerPercent.Size = new System.Drawing.Size(21, 20);
            this.lbl_SannerPercent.TabIndex = 3;
            this.lbl_SannerPercent.Text = "%";
            // 
            // lbl_ScannerPort
            // 
            this.lbl_ScannerPort.AutoSize = true;
            this.lbl_ScannerPort.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ScannerPort.Location = new System.Drawing.Point(617, 103);
            this.lbl_ScannerPort.Name = "lbl_ScannerPort";
            this.lbl_ScannerPort.Size = new System.Drawing.Size(17, 20);
            this.lbl_ScannerPort.TabIndex = 4;
            this.lbl_ScannerPort.Text = "1";
            // 
            // list_CanUsePortList
            // 
            this.list_CanUsePortList.FormattingEnabled = true;
            this.list_CanUsePortList.ItemHeight = 12;
            this.list_CanUsePortList.Location = new System.Drawing.Point(43, 145);
            this.list_CanUsePortList.Name = "list_CanUsePortList";
            this.list_CanUsePortList.Size = new System.Drawing.Size(268, 292);
            this.list_CanUsePortList.TabIndex = 5;
            // 
            // richTxt_SendingInfo
            // 
            this.richTxt_SendingInfo.Location = new System.Drawing.Point(346, 145);
            this.richTxt_SendingInfo.Name = "richTxt_SendingInfo";
            this.richTxt_SendingInfo.Size = new System.Drawing.Size(402, 181);
            this.richTxt_SendingInfo.TabIndex = 6;
            this.richTxt_SendingInfo.Text = "";
            // 
            // btn_StartScan
            // 
            this.btn_StartScan.Location = new System.Drawing.Point(621, 41);
            this.btn_StartScan.Name = "btn_StartScan";
            this.btn_StartScan.Size = new System.Drawing.Size(127, 22);
            this.btn_StartScan.TabIndex = 7;
            this.btn_StartScan.Text = "开始扫描";
            this.btn_StartScan.UseVisualStyleBackColor = true;
            this.btn_StartScan.Click += new System.EventHandler(this.btn_StartScan_Click);
            // 
            // lbl_SelectPort
            // 
            this.lbl_SelectPort.AutoSize = true;
            this.lbl_SelectPort.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SelectPort.Location = new System.Drawing.Point(354, 352);
            this.lbl_SelectPort.Name = "lbl_SelectPort";
            this.lbl_SelectPort.Size = new System.Drawing.Size(17, 20);
            this.lbl_SelectPort.TabIndex = 8;
            this.lbl_SelectPort.Text = "0";
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Send.Location = new System.Drawing.Point(452, 401);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 9;
            this.btn_Send.Text = "发送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_UseEncoding
            // 
            this.txt_UseEncoding.Location = new System.Drawing.Point(598, 354);
            this.txt_UseEncoding.Name = "txt_UseEncoding";
            this.txt_UseEncoding.Size = new System.Drawing.Size(150, 21);
            this.txt_UseEncoding.TabIndex = 10;
            // 
            // lbl_SendEncoding
            // 
            this.lbl_SendEncoding.AutoSize = true;
            this.lbl_SendEncoding.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SendEncoding.Location = new System.Drawing.Point(469, 354);
            this.lbl_SendEncoding.Name = "lbl_SendEncoding";
            this.lbl_SendEncoding.Size = new System.Drawing.Size(124, 20);
            this.lbl_SendEncoding.TabIndex = 11;
            this.lbl_SendEncoding.Text = "输入要使用的编码:";
            // 
            // txt_portFrom
            // 
            this.txt_portFrom.Location = new System.Drawing.Point(473, 41);
            this.txt_portFrom.Name = "txt_portFrom";
            this.txt_portFrom.Size = new System.Drawing.Size(53, 21);
            this.txt_portFrom.TabIndex = 14;
            this.txt_portFrom.Text = "1";
            // 
            // lbl_Spliter
            // 
            this.lbl_Spliter.AutoSize = true;
            this.lbl_Spliter.Location = new System.Drawing.Point(532, 46);
            this.lbl_Spliter.Name = "lbl_Spliter";
            this.lbl_Spliter.Size = new System.Drawing.Size(11, 12);
            this.lbl_Spliter.TabIndex = 15;
            this.lbl_Spliter.Text = "-";
            // 
            // txt_portEnd
            // 
            this.txt_portEnd.Location = new System.Drawing.Point(545, 41);
            this.txt_portEnd.Name = "txt_portEnd";
            this.txt_portEnd.Size = new System.Drawing.Size(53, 21);
            this.txt_portEnd.TabIndex = 16;
            this.txt_portEnd.Text = "65535";
            // 
            // btn_ReScan
            // 
            this.btn_ReScan.BackColor = System.Drawing.Color.White;
            this.btn_ReScan.ForeColor = System.Drawing.Color.Salmon;
            this.btn_ReScan.Location = new System.Drawing.Point(346, 401);
            this.btn_ReScan.Name = "btn_ReScan";
            this.btn_ReScan.Size = new System.Drawing.Size(75, 23);
            this.btn_ReScan.TabIndex = 17;
            this.btn_ReScan.Text = "ReScan";
            this.btn_ReScan.UseVisualStyleBackColor = false;
            this.btn_ReScan.Click += new System.EventHandler(this.btn_ReScan_Click);
            // 
            // lbl_ReciveStatus
            // 
            this.lbl_ReciveStatus.AutoSize = true;
            this.lbl_ReciveStatus.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ReciveStatus.Location = new System.Drawing.Point(574, 402);
            this.lbl_ReciveStatus.Name = "lbl_ReciveStatus";
            this.lbl_ReciveStatus.Size = new System.Drawing.Size(0, 20);
            this.lbl_ReciveStatus.TabIndex = 18;
            // 
            // txtBox_MaxThreadPool
            // 
            this.txtBox_MaxThreadPool.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBox_MaxThreadPool.Location = new System.Drawing.Point(543, 102);
            this.txtBox_MaxThreadPool.Name = "txtBox_MaxThreadPool";
            this.txtBox_MaxThreadPool.Size = new System.Drawing.Size(64, 23);
            this.txtBox_MaxThreadPool.TabIndex = 19;
            this.txtBox_MaxThreadPool.Text = "20";
            this.toolTip_MaxThread.SetToolTip(this.txtBox_MaxThreadPool, "最大线程数应介于20-150之间");
            // 
            // lbl_MaxThread
            // 
            this.lbl_MaxThread.AutoSize = true;
            this.lbl_MaxThread.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_MaxThread.Location = new System.Drawing.Point(458, 101);
            this.lbl_MaxThread.Name = "lbl_MaxThread";
            this.lbl_MaxThread.Size = new System.Drawing.Size(79, 20);
            this.lbl_MaxThread.TabIndex = 20;
            this.lbl_MaxThread.Text = "最大线程数";
            // 
            // toolTip_MaxThread
            // 
            this.toolTip_MaxThread.AutoPopDelay = 5000;
            this.toolTip_MaxThread.InitialDelay = 200;
            this.toolTip_MaxThread.ReshowDelay = 100;
            this.toolTip_MaxThread.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 457);
            this.Controls.Add(this.lbl_MaxThread);
            this.Controls.Add(this.txtBox_MaxThreadPool);
            this.Controls.Add(this.lbl_ReciveStatus);
            this.Controls.Add(this.btn_ReScan);
            this.Controls.Add(this.txt_portEnd);
            this.Controls.Add(this.lbl_Spliter);
            this.Controls.Add(this.txt_portFrom);
            this.Controls.Add(this.lbl_SendEncoding);
            this.Controls.Add(this.txt_UseEncoding);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.lbl_SelectPort);
            this.Controls.Add(this.btn_StartScan);
            this.Controls.Add(this.richTxt_SendingInfo);
            this.Controls.Add(this.list_CanUsePortList);
            this.Controls.Add(this.lbl_ScannerPort);
            this.Controls.Add(this.lbl_SannerPercent);
            this.Controls.Add(this.pg_ScannerPg);
            this.Controls.Add(this.txtBox_ScannerInput);
            this.Controls.Add(this.lbl_SannerInput);
            this.MaximumSize = new System.Drawing.Size(805, 495);
            this.MinimumSize = new System.Drawing.Size(805, 495);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SannerInput;
        private System.Windows.Forms.TextBox txtBox_ScannerInput;
        private System.Windows.Forms.ProgressBar pg_ScannerPg;
        private System.Windows.Forms.Label lbl_SannerPercent;
        private System.Windows.Forms.Label lbl_ScannerPort;
        private System.Windows.Forms.ListBox list_CanUsePortList;
        private System.Windows.Forms.RichTextBox richTxt_SendingInfo;
        private System.Windows.Forms.Button btn_StartScan;
        private System.Windows.Forms.Label lbl_SelectPort;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_UseEncoding;
        private System.Windows.Forms.Label lbl_SendEncoding;
        private System.Windows.Forms.TextBox txt_portFrom;
        private System.Windows.Forms.Label lbl_Spliter;
        private System.Windows.Forms.TextBox txt_portEnd;
        private System.Windows.Forms.Button btn_ReScan;
        private System.Windows.Forms.Label lbl_ReciveStatus;
        private System.Windows.Forms.TextBox txtBox_MaxThreadPool;
        private System.Windows.Forms.Label lbl_MaxThread;
        private System.Windows.Forms.ToolTip toolTip_MaxThread;
    }
}

