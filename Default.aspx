<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>商品管理系统演示</title>
</head>
        <style>
            *
            {
            	margin:0 auto;
            	padding:0;
            }
            table
            {
            	width:100%;
            	height:700px;
            }
            .bt
            {
            	text-align:center;
            	height:100px;
            }
            .login
            {
            	width:200px;
            	height:400px;
            }
            .img
            {
            	width:60%;
            }
            body
            {
            	background-color:#ede3e7
            }
        </style>
<body>
    <form id="form1" runat="server">
    <table>
    <tr>
         <td colspan="2" class="bt">
             <h1><asp:Label ID="Label1" runat="server" Text="登陆界面" ></asp:Label></h1><hr /></td>
    </tr>
    <tr>
        <td rowspan="2" class="img"><img src="login.jpg" width="800px" height="450px"/></td>
        <td class="login">
           用户名:&nbsp;<asp:TextBox ID="nametxt" runat="server" Width="150px" Height="20px"></asp:TextBox><br /><br />
            &nbsp;密码:&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="pwdtxt"
                runat="server" Width="150px" Height="20px"></asp:TextBox><br /><br />
            &nbsp;<asp:Button ID="Button1" runat="server" Text="注册" onclick="Button1_Click" Width="50px" Height="25px"/> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
             <asp:Button ID="Button2" runat="server" Text="登录" onclick="Button2_Click" Width="50px" Height="25px" />
    </tr>
    <tr></tr>
    <tr align="center">
        <td class="bq" colspan="2">
        <hr />©2019 &nbsp;FTS &nbsp;copyright </td>
     </tr>
    </form>
    </table>
</body>
</html>
