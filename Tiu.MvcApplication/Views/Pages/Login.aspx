<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>:: 登录界面 ::</title>
    <%= Html.ImportFileResources(Url) %>
    <style type="text/css">
        .loginfield tr td,.loginfield tr th
        {
            padding:4px 0;
        }
    </style>
</head>
<body class="loginpage">
    <div id="lw" title="Basic Window">
        <form id="loginForm" method="post">
		<table class="loginfield">
            <thead>
                <tr>
                    <th colspan="3">
                        开发框架
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th>用户名：</th>
                    <td><input type="text" name="Account" class="easyui-validatebox" data-options="required:true" maxlength="20"/></td>
                    <td><span class="error">*</span></td>
                </tr>
                <tr>
                    <th>密 码：</th>
                    <td><input type="password" name="Pwd" class="easyui-validatebox" data-options="required:true" maxlength="20" /></td>
                    <td><span class="error">*</span></td>
                </tr>
                <tr>
                    <th></th>
                    <td><a id="btnLogin">登 录</a></td>
                    <td></td>
                </tr>
            </tbody>
        </table>
        </form>
	</div>

    <script type="text/javascript">
        var Login = {
            // 初始化
            Init: function () {
                this.LoginWindow.Init();
                this.LoginForm.Init();
                this.Buttons.Init();
            },
            // 登录框
            LoginWindow: {
                Obj: $("#lw"),
                Init: function () {
                    this.Obj.dialog({
                        title: "欢迎登录本系统",
                        width: 360,
                        height: 240,
                        top:200,
                        resizable: false,
                        draggable: false,
                        closable: false
                    });
                }
            },
            // 登录表单
            LoginForm: {
                Obj: $("#loginForm"),
                Init: function () {
                    this.Obj.form({
                        url: "Pages/DoLogin",
                        onSubmit: function () {
                            var validated = $(this).form("validate");
                            return validated;
                        },
                        success: function (data) {
                            if (data == "1") {
                                //$.messager.alert("系统提示", "登录成功！", "info");
                                window.location.href = "Pages/Index";
                            }
                            else {
                                $.messager.alert("系统提示", data, "error");
                            }
                        }
                    });
                },
                Submit: function () {
                    this.Obj.submit();
                }
            },
            // 按钮
            Buttons: {
                Init: function () {
                    this.SubmitButton.Init();
                },
                // 登录表单提交按钮
                SubmitButton: {
                    Obj: $("#btnLogin"),
                    Init: function () {
                        this.Obj.linkbutton({
                            iconCls: "icon-tip"
                        });
                        this.Obj.click(function () {
                            Login.LoginForm.Submit();
                        });
                    }
                }
            }
        };

        $(function () {
            Login.Init();
        });
    </script>
</body>
</html>
