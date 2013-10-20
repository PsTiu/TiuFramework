using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tiu.MvcApplication
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

    }
}
