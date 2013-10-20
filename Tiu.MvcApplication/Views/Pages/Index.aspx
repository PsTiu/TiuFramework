<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>:: web系统开发框架 ::</title>
    <%= Html.ImportFileResources(Url) %>
</head>

<%
    var siteInfo = ViewData["SiteInfos"] as Tiu.Common.ConfigSections.SiteInfos;
     %>

<body id="body" class="easyui-layout">
    <div data-options="region:'north',border:false" style="height: 60px; padding: 10px;
        background-color: #E0ECFF;">
        <span class='sysname'><%= siteInfo.SiteName %></span>
    </div>
    <div data-options="region:'west',split:true,title:'功能菜单'" style="width: 180px; padding: 10px;">
        <ul id="ulNavigate">
        </ul>
    </div>
    <div id="funPageRegion" data-options="region:'center'" title="系统功能标题">
        <iframe id="funPageFrame" frameborder="0" src="" style="width: 100%; height: 100%">
        </iframe>
    </div>
    <div data-options="region:'south',border:false" style="height: 26px; background: #E0ECFF;
        padding: 4px; text-align: center;">
        <span class='copyright'>Copyright © 1998-<%= DateTime.Now.Year %>
            By PsTiu</span>
    </div>
    <script type="text/javascript">
        var Main = {
            // 页面控件
            Controls: {
                Navigate: $("#ulNavigate")
            },
            InitNavigate: function () {
                this.Controls.Navigate.tree({
                    url: "/Pages/GetNavigate",
                    onClick: function (node) {
                        if (node.attributes && node.attributes["url"]) {
                            Main.OpenPage(node.attributes["url"]);
                        }
                    }
                });
            },
            // 打开功能页面
            OpenPage: function (url) {
                window.frames["funPageFrame"].location.href = url;
            },
            // 设置功能页标题
            SetPageTitle: function (title) {
                $("#body").layout("panel", "center").panel("setTitle", title);
            }
        };

        $(function () {
            Main.InitNavigate();
        });
    </script>
</body>
</html>
