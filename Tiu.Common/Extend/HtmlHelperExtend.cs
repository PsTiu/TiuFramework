using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.Mvc
{
    /// <summary>
    /// HtmlHelper扩展
    /// </summary>
    public static class HtmlHelperExtend
    {
        /// <summary>
        /// 引入css文件
        /// </summary>
        /// <param name="helper">HtmlHelper</param>
        /// <param name="urlHelper">UrlHelper</param>
        /// <param name="fileVPaths">css文件的虚拟路径（可多个，按顺序引入，格式为 ~/dir/filename.css）</param>
        /// <returns></returns>
        public static string ImportCss(this HtmlHelper helper, UrlHelper urlHelper, params string[] fileVPaths)
        {
            var output = new StringBuilder();
            foreach (var fileVPath in fileVPaths)
            {
                var href = urlHelper.Content(fileVPath);
                output.AppendFormat("<link href=\"{0}\" rel=\"stylesheet\" type=\"text/css\" />", href);
            }
            return output.ToString();
        }

        /// <summary>
        /// 引入js文件
        /// </summary>
        /// <param name="helper">HtmlHelper</param>
        /// <param name="urlHelper">UrlHelper</param>
        /// <param name="fileVPaths">js文件的虚拟路径（可多个，按顺序引入，格式为 ~/dir/filename.js）</param>
        /// <returns></returns>
        public static string ImportJs(this HtmlHelper helper, UrlHelper urlHelper, params string[] fileVPaths)
        {
            var output = new StringBuilder();
            foreach (var fileVPath in fileVPaths)
            {
                var src = urlHelper.Content(fileVPath);
                output.AppendFormat("<script src=\"{0}\" type=\"text/javascript\"></script>", src);
            }
            return output.ToString();
        }

        /// <summary>
        /// 导入文件资源（通用的css和js）
        /// </summary>
        /// <param name="helper">HtmlHelper</param>
        /// <param name="urlHelper">UrlHelper</param>
        /// <param name="urlHelper"></param>
        /// <returns></returns>
        public static string ImportFileResources(this HtmlHelper helper, UrlHelper urlHelper, string theme = "default")
        {
            var re = ImportCss(helper, urlHelper
                , "~/Styles/core_default.css"
                , "~/Scripts/jquery-easyui/themes/icon.css"
                , "~/Scripts/jquery-easyui/themes/" + theme + "/easyui.css");
            re += ImportJs(helper, urlHelper
                , "~/Scripts/jquery-easyui/jquery-min.js"
                , "~/Scripts/jquery-easyui/jquery.easyui.min.js"
                , "~/Scripts/jquery-easyui/locale/easyui-lang-zh_CN.js");
            return re;
        }
    }
}
