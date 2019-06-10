using System;
using System.Collections;
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

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string connString = "server=localhost;Integrated Security=True;database=SuperMarket";
        SqlConnection conn = new SqlConnection(connString);
        conn.Open();
        string username, userpwd;
        username = nametxt.Text.Replace("'", "''");
        userpwd = pwdtxt.Text.Replace("'", "''");
        string sql = "select count(*) from userinfo where name='" + username + "' and pwd='" + userpwd + "'";
        SqlCommand cmd = new SqlCommand(sql, conn);
        int count = (int)cmd.ExecuteScalar();
        if (count == 1)
        {
            Response.Write("用户已存在");
        }
        else
        {
            string strSql = "insert into userinfo(name,pwd) values('" + nametxt.Text + "','" + pwdtxt.Text + "')";
            SqlCommand com = new SqlCommand(strSql, conn);
            int rowCount = com.ExecuteNonQuery();
            conn.Close();
            Response.Write("注册成功");
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
