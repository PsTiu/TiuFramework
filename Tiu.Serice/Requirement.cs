using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tiu.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class Requirement : BaseService
    {
        /// <summary>
        /// 新增需求
        /// </summary>
        /// <param name="requirement"></param>
        public OperResult AddRequirement(Tiu.DAO.Requirement requirement)
        {
            var re = new OperResult();
            try
            {
                _oaprDao.Requirement.InsertOnSubmit(requirement);
                _oaprDao.SubmitChanges();
                re.Result = E_Result.Successed;
            }
            catch (Exception ex)
            {
                re.Message = re.Message;
                WriteException(ex);
            }
            return re;
        }

        /// <summary>
        /// 获取所有需求
        /// </summary>
        /// <returns></returns>
        public ICollection<Tiu.DAO.Requirement> GetAllRequirements()
        {
            try
            {
                return _oaprDao.Requirement.ToList();
            }
            catch (Exception ex)
            {
                WriteException(ex);
                return null;
            }
        }
    }
}
