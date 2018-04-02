﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpStatusMonitor
{
    /// <summary>
    /// 定义异常通知通道
    /// </summary>
    public interface INotifyChannel
    {
        /// <summary>
        /// 异常通知
        /// </summary>
        /// <param name="Title">标题</param>
        /// <param name="ex">异常</param>
        /// <returns></returns>
        Task NotifyAsync(string Title, Exception ex);
    }
}