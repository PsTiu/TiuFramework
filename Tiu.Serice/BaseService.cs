using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tiu.Service
{
    /// <summary>
    /// 业务操作结果枚举
    /// </summary>
    public enum E_Result
    {
        /// <summary>
        /// 操作成功
        /// </summary>
        Successed = 1,
        /// <summary>
        /// 操作失败（非异常）
        /// </summary>
        Failed = 2,
        /// <summary>
        /// 出错（异常）
        /// </summary>
        Error = 3
    }

    /// <summary>
    /// 业务逻辑操作结果
    /// </summary>
    public class OperResult
    {
        /// <summary>
        /// 结果
        /// </summary>
        public E_Result Result { get; set; }
        /// <summary>
        /// 附加信息
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// 业务逻辑基础类
    /// </summary>
    public class BaseService
    {
        /// <summary>
        /// 数据库访问对象
        /// </summary>
        protected DAO.Oapr _oaprDao = new DAO.Oapr();

        /// <summary>
        /// 写异常日志
        /// </summary>
        /// <param name="ex">异常</param>
        protected void WriteException(Exception ex)
        { 
        
        }

        /// <summary>
        /// 写异常日志
        /// </summary>
        /// <param name="ex">异常信息</param>
        protected void WriteException(string ex)
        { 
            
        }

        /// <summary>
        /// 写操作日志
        /// </summary>
        /// <param name="desc">操作内容描述</param>
        protected void WriteOperLog(string desc)
        { 
        
        }
    }
}
