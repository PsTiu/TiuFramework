using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tiu.Common.ConfigSections
{
    /// <summary>
    /// 用于读取配置信息的类
    /// </summary>
    public static class SectionHelper
    {
        /// <summary>
        /// 站点信息
        /// </summary>
        public static SiteInfos SiteInfos
        {
            get
            {
                var re = System.Configuration.ConfigurationManager.GetSection("SiteInfos");
                return re as SiteInfos;
            }
        }

        /// <summary>
        /// 各种锁
        /// </summary>
        public static SiteLocks SiteLocks
        {
            get
            {
                var re = System.Configuration.ConfigurationManager.GetSection("SiteLocks");
                return re as SiteLocks;
            }
        }
    }
}
