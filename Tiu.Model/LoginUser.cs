using System;
using System.Collections.Generic;
using System.Linq;

namespace Tiu.Model
{
    /// <summary>
    /// 登录用户基础信息
    /// </summary>
    public class LoginUserBasic
    {
        /// <summary>
        /// 帐号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { get; set; }
    }

    /// <summary>
    /// 登录用户详细信息
    /// </summary>
    public class LoginUserInfo:LoginUserBasic
    {
        public string UserId { get; set; }

        public string UserFullName { get; set; }
    }
}
