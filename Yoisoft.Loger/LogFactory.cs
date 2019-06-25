﻿using log4net;
using System;

namespace Yoisoft.Loger
{
    public class LogFactory
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        static LogFactory()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
        /// <summary>
        /// 获取日志操作对象
        /// </summary>
        /// <param name="type">类型</param>
        /// <returns></returns>
        public static Log GetLogger(Type type)
        {
            return new Log(LogManager.GetLogger(type));
        }
        /// <summary>
        /// 获取日志操作对象
        /// </summary>
        /// <param name="str">名字</param>
        /// <returns></returns>
        public static Log GetLogger(string str)
        {
            return new Log(LogManager.GetLogger(str));
        }
    }
}
