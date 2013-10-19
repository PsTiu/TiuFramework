using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tiu.Service
{
    /// <summary>
    /// 登录用户信息（单例）
    /// </summary>
    public class LoginInfo
    {
        private volatile static LoginInfo _instance = null;
        private static readonly object _lockHelper = new object();
        private LoginInfo() { }

        /// <summary>
        /// 获取当前登录用户信息
        /// </summary>
        /// <returns></returns>
        public static LoginInfo GetCurLoginInfo()
        {
            if (_instance == null)
            {
                lock (_lockHelper)
                {
                    if (_instance == null)
                    {
                        _instance = new LoginInfo();
                    }
                }
            }
            return _instance;
        }

        /// <summary>
        /// 用户id
        /// </summary>
        public string UserId
        {
            set
            {
                System.Web.HttpContext.Current.Session["LoginInfo.UserId"] = value;
            }
            get
            {
                if (System.Web.HttpContext.Current != null && System.Web.HttpContext.Current.Session != null)
                {
                    if (System.Web.HttpContext.Current.Session["LoginInfo.UserId"] != null)
                    {
                        return System.Web.HttpContext.Current.Session["LoginInfo.UserId"].ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        /// <summary>
        /// 用户全名（id(名字)）
        /// </summary>
        public string UsreFullName
        {
            set
            {
                System.Web.HttpContext.Current.Session["LoginInfo.UsreFullName"] = value;
            }
            get
            {
                if (System.Web.HttpContext.Current != null && System.Web.HttpContext.Current.Session != null)
                {
                    if (System.Web.HttpContext.Current.Session["LoginInfo.UsreFullName"] != null)
                    {
                        return System.Web.HttpContext.Current.Session["LoginInfo.UsreFullName"].ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}
