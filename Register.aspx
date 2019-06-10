<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>注册</title>
    <style>
   .bg
    {
    	margin:0px auto;

    }
    body
    {
    	background-color:#ede3e7;
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width:51; height: 100px;" class="bg">
        <tr>
            <td class="" colspan="2">
            <h2>注册页面</h2>
            <hr />
            </td>
        </tr>
        <tr>
            <td class="">
                用户名</td>
            <td class="">
                <asp:TextBox ID="nametxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="">
                密码</td>
            <td class="">
                <asp:TextBox ID="pwdtxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="">
                <asp:Button ID="Button1" runat="server" Text="注册" onclick="Button1_Click" />
          </td>
          <td class="">
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="退出" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
