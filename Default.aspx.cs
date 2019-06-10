using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        //下面是在每个页面中需要设置和数据库的连接
        //string connString = "server=localhost;Integrated Security=True;database=SuperMarket";
        //SqlConnection conn = new SqlConnection(connString);
        //  conn.Open();
        //下面这种连接方式是把数据库连接字符串写在webconfig文件中，在.cs文件中需要按照下面的配置数据库
        string consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["conn"].ToString();
        SqlConnection conn = new SqlConnection(consql);
        conn.Open();
        string username, userpwd;
        username = nametxt.Text.Replace("'", "''");
        userpwd = pwdtxt.Text.Replace("'", "''");
        string sql = "select count(*) from userinfo where name='" + username + "' and pwd='" + userpwd + "'";
        SqlCommand cmd = new SqlCommand(sql, conn);
        int count = (int)cmd.ExecuteScalar();
        if (count == 1)
        {
            Response.Redirect("Default2.aspx");
        }
        else
            Response.Write("用户名或者密码错误");
        conn.Close();
    }
}
