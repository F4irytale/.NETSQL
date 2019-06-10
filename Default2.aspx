<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<style>
    .right
    {
    	padding-left:100px;
    }
body
{
	background-color:#ede3e7;
}
table
{
	width:100%;
	height:650px;
}
.td1
{
	width:75%;
	height:500px;
}
</style>
<body>
    <form id="form1" runat="server">
    <fildset>
    <lenged></lenged>
    <div>
    <table>
    <caption><h1>管理系统</h1></caption>
    <tr>
    <td class="td1">
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="SqlDataSource1" Height="630px">
           <Columns>
               <asp:BoundField DataField="编号" HeaderText="编号" 
                   SortExpression="编号" />
               <asp:BoundField DataField="价格" HeaderText="价格" SortExpression="价格" />
               <asp:BoundField DataField="名称" HeaderText="名称" SortExpression="名称" />
               <asp:BoundField DataField="库存" HeaderText="库存" SortExpression="库存" />
           </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:SUPERMARKETConnectionString3 %>" 
            SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
        </td>
    <td class="right">
    <asp:Label ID="Label1" runat="server" Text="编号："></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
    <asp:Label ID="Label2" runat="server" Text="价格："></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
    <asp:Label ID="Label3" runat="server" Text="名称："></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /><br />
    <asp:Label ID="Label4" runat="server" Text="库存："></asp:Label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br /><br />
    
    
    
    
    
    <asp:Button ID="Button1" runat="server" Text="添加" onclick="Button1_Click"></asp:Button>
    <asp:Button ID="Button3" runat="server" Text="查询" onclick="Button3_Click"></asp:Button><br /><br />
    <asp:Button ID="Button4" runat="server" Text="删除" onclick="Button4_Click"></asp:Button>
    <asp:Button ID="Button5" runat="server" Text="重置" onclick="Button5_Click"></asp:Button>
 </td>
    </tr>
        <tr>
    <td colspan="2"><hr />©2019 &nbsp;FTS &nbsp;copyright</td>
    </tr>
    </fildset>
    </form>
</body>
</html>
