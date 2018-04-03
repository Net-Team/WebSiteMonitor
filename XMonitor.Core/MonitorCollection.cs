﻿using System.Collections;
using System.Collections.Generic;

namespace XMonitor.Core
{
    /// <summary>
    /// 表示监控的对象集合
    /// </summary>
    public class MonitorCollection<TMonitor> : IEnumerable<TMonitor> where TMonitor : IMonitor
    {
        /// <summary>
        /// 监控的对象列表
        /// </summary>
        private readonly List<TMonitor> monitors = new List<TMonitor>();

        /// <summary>
        /// 获取监控对象的数量
        /// </summary>
        public int Count => this.monitors.Count;

        /// <summary>
        /// 添加监控对象
        /// </summary>
        /// <param name="monitor">监控对象</param>
        protected void Add(TMonitor monitor)
        {
            this.monitors.Add(monitor);
        }

        /// <summary>
        /// 返回监控对象迭代器
        /// </summary>
        /// <returns></returns>
        public IEnumerator<TMonitor> GetEnumerator()
        {
            return this.monitors.GetEnumerator();
        }

        /// <summary>
        /// 返回监控对象迭代器
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}