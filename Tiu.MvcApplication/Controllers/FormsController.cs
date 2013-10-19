using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tiu.MvcApplication.Controllers
{
    public class FormsController : Controller
    {
        /// <summary>
        /// 填写需求综述表单页面
        /// </summary>
        /// <returns></returns>
        public ActionResult RequirementsSummary()
        {
            var curLoginInfo = Service.LoginInfo.GetCurLoginInfo();
            
            DAO.Requirement newRequirement = new DAO.Requirement();
            newRequirement.Rid = DAO.Requirement.NewRID();
            newRequirement.Backgroud = "需求背景-" + newRequirement.Rid;
            newRequirement.CreateTime = DateTime.Now;
            newRequirement.CreatorFulleName = curLoginInfo.UsreFullName;
            newRequirement.CreatorID = curLoginInfo.UserId;
            newRequirement.CurNodeID = "10001";
            newRequirement.Detail = "需求描述-" + newRequirement.Rid;
            newRequirement.IsEnd = 0;
            newRequirement.IsSplited = 0;
            newRequirement.OperatorFullName = curLoginInfo.UsreFullName;
            newRequirement.OperatorID = curLoginInfo.UserId;
            newRequirement.ProductionID = 1;
            newRequirement.ProductionStageID = 6;
            newRequirement.RequirementTime = DateTime.Now.AddDays(7);
            newRequirement.StatusID = 1;
            newRequirement.Title = "需求标题-" + newRequirement.Rid;
            newRequirement.UpdateTime = DateTime.Now;


            Service.Requirement requirementSvc = new Service.Requirement();
            var re = requirementSvc.AddRequirement(newRequirement);
            return Content(re.Result.ToString());
            //return View();
        } 

    }
}
