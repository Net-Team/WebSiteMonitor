﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorServices
{
    /// <summary>
    /// 表示通知上下文
    /// </summary>
    public class NotifyContext
    {
        /// <summary>
        /// 获取或设置消息源
        /// 比如为站点的Url等
        /// </summary>
        public string SourceName { get; set; }

        /// <summary>
        /// 获取或设置异常内容
        /// </summary>
        public Exception Exception { get; set; }
    }
}