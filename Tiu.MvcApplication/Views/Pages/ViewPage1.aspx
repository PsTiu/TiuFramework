<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>:: 系统首页 ::</title>
    <%= Html.ImportFileResources(Url) %>
</head>
<body>
    <div style="padding:12px;">
        <p>本框架客户端基于EasyUI &nbsp; <a href="http://www.jeasyui.com">http://www.jeasyui.com</a></p>
        <p>服务端基于Asp.Net MVC 2.0</p>
        <p>系统当前时间：<%= ViewData["dt"].ToString() %> （通过ViewData展示）</p>
    </div>

    <script type="text/javascript">
        window.top.window.Main.SetPageTitle(document.title);
    </script>
</body>
</html>
