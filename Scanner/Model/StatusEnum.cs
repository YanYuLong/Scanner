﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scanner.BLL;

namespace Scanner.Model
{
    public enum WorkStatus
    {
        /// <summary>
        /// 扫描状态
        /// </summary>
        [ScanStatus(new string[]{ "pg_ScannerPg", "lbl_ScannerPort", "lbl_SannerPercent", "lbl_SannerInput" })]
        Scan,
        [ScanCompleteStatus(new string[] { "btn_ensureSelectPort", "btn_StartScan", "txtBox_ScannerInput", "btn_Send" , "list_CanUsePortList", "txt_UseEncoding", "lbl_SannerInput" })]
        ScanComplete,
        /// <summary>
        /// 程序刚被初始化状态（空闲状态）
        /// </summary>
        [InitStatus(new string[] { "txtBox_ScannerInput", "btn_StartScan", "lbl_SannerInput", "txt_portFrom", "txt_portEnd" })]
        Init,
        /// <summary>
        /// 向远程端口发送数据状态
        /// </summary>
        [SendingDataStatus(new string[] { "btn_SendStop" })]
        SendingData,
        /// <summary>
        /// 异常状态
        /// </summary>
        [ExceptionStatus(new string[] { "" })]
        Exception
    }
}
