using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tiu.MvcApplication.Controllers
{
    /// <summary>
    /// 控制器基础类
    /// </summary>
    public class BasicController : Controller
    {
        /// <summary>
        /// 用户登录信息的session key
        /// </summary>
        private const string SESSION_KEY_LOGINUSERINFO = "C3D1BB37A02249FA91AF05AAFADDDBF5";

        /// <summary>
        /// 获取当前登录用户的详细信息（从session中获取）
        /// </summary>
        /// <returns></returns>
        protected Model.LoginUserInfo GetLoginUserInfo()
        {
            if (Session[SESSION_KEY_LOGINUSERINFO] != null)
            {
                return Session[SESSION_KEY_LOGINUSERINFO] as Model.LoginUserInfo;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 保存当前登录用户信息（保存到session中）
        /// </summary>
        /// <param name="loginUserInfo">登录用户详细信息</param>
        protected void SaveLoginUserInfo(Model.LoginUserInfo loginUserInfo)
        {
            Session[SESSION_KEY_LOGINUSERINFO] = loginUserInfo;
        }
    }
}
