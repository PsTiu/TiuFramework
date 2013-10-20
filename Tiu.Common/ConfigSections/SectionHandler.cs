using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Tiu.Common.ConfigSections
{
    /// <summary>
    /// 用于读取config文件中自定义section的类
    /// </summary>
    public class SectionHandler : IConfigurationSectionHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="configContext"></param>
        /// <param name="section"></param>
        /// <returns></returns>
        public object Create(object parent, object configContext, System.Xml.XmlNode section)
        {
            var obj = new object();
            switch (section.Name)
            {
                case "SiteInfos":
                    var siteInfos = new SiteInfos();
                    siteInfos.SiteName = section["SiteName"].InnerText;
                    siteInfos.LogoUrl = section["LogoUrl"].InnerText;
                    obj = siteInfos;
                    break;
                case "SiteLocks":
                    var siteLocks = new SiteLocks();
                    siteLocks.Lock1 = section["Lock1"] != null ? section["Lock1"].ToString().ToLower() == "true" : false;
                    siteLocks.Lock2 = section["Lock2"] != null ? section["Lock2"].ToString().ToLower() == "true" : false;
                    siteLocks.Lock3 = section["Lock3"] != null ? section["Lock3"].ToString().ToLower() == "true" : false;
                    obj = siteLocks;
                    break;
                default:
                    break;
            }
            return obj;
        }
    }
}
