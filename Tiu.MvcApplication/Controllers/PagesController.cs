using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace Tiu.MvcApplication.Controllers
{
    public class PagesController : BasicController
    {
        /// <summary>
        /// 显示主框架页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            // 初始化登录用户（测试用）
            var curLoginInfo = new Model.LoginUserInfo();
            curLoginInfo.UserId = "PsTiu";
            curLoginInfo.UserFullName = "PsTiu(彭仕涛)";

            ViewData["SiteInfos"] = Tiu.Common.ConfigSections.SectionHelper.SiteInfos;

            return View();
        }

        /// <summary>
        /// 获取导航菜单
        /// </summary>
        /// <returns></returns>
        public ActionResult GetNavigate()
        {
            var path = Server.MapPath("~/App_Data/navigate.json");
            var re = System.IO.File.ReadAllText(path, Encoding.GetEncoding("GBK"));
            return Content(re);
        }

        
        /// <summary>
        /// 显示登录页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 登录操作
        /// </summary>
        /// <returns></returns>
        public ActionResult DoLogin()
        {
            return Content(DateTime.Now.Second % 2 == 0 ? "1" : "登录失败！");
        }



        #region test
        /// <summary>
        /// /Pages/ViewPage1
        /// </summary>
        /// <returns></returns>
        public ActionResult ViewPage1()
        {
            ViewData["dt"] = DateTime.Now;
            return View();
        }

        /// <summary>
        /// /Pages/ViewPage1
        /// </summary>
        /// <returns></returns>
        public ActionResult ViewPage2(string desc)
        {
            return View();
        }
        #endregion    
    }
}
