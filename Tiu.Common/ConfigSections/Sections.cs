using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tiu.Common.ConfigSections
{
    /// <summary>
    /// 站点信息
    /// </summary>
    public class SiteInfos
    {
        public string SiteName { get; set; }
        public string LogoUrl { get; set; }
    }

    /// <summary>
    /// 各种锁标识
    /// </summary>
    public class SiteLocks
    {
        public bool Lock1 { get; set; }
        public bool Lock2 { get; set; }
        public bool Lock3 { get; set; }
    }
}
