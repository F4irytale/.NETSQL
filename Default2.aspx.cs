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
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == null)
        {
            Response.Write("请输入编号");
        }
        else
        {
            string consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["conn"].ToString();
            SqlConnection conn = new SqlConnection(consql);
            conn.Open();
            String sql = "select * from Product where 编号 = @sno";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@sno", TextBox1.Text));
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TextBox2.Text = reader.GetString(reader.GetOrdinal("价格"));
                TextBox3.Text = reader.GetString(reader.GetOrdinal("名称"));
                TextBox4.Text = reader.GetString(reader.GetOrdinal("库存"));
                conn.Close();

            }
            else
            {

                Response.Write("没有查到该商品！");
            }


        }

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == null)
        {
            Response.Write("请输入编号");
        }
        else
        {
            string consql = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["conn"].ToString();
            SqlConnection conn = new SqlConnection(consql);
            conn.Open();
            string MyDelete = "Delete from product where 编号=" + TextBox1.Text;
            SqlCommand MyCommand = new SqlCommand(MyDelete, conn);
            try
            {
                MyCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);

            }
            GridView1.DataSourceID = "";
            GridView1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }

    }
    protected void Button5_Click(object sender, EventArgs e)
    {


        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string connString = "server=localhost;Integrated Security=True;database=SuperMarket";
        SqlConnection conn = new SqlConnection(connString);
        conn.Open();
        string username, userpwd;
        username = TextBox1.Text.Replace("'", "''");
        userpwd = TextBox2.Text.Replace("'", "''");
        string sql = "select count(*) from product where 编号='" + username + "'";
        SqlCommand cmd = new SqlCommand(sql, conn);
        int count = (int)cmd.ExecuteScalar();
        if (count == 1)
        {
            Response.Write("商品已存在");
        }
        else
        {
            string strSql = "insert into product(编号,价格,名称,库存) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            SqlCommand com = new SqlCommand(strSql, conn);
            int rowCount = com.ExecuteNonQuery();
            conn.Close();
            Response.Write("添加成功");
            GridView1.DataSourceID = "";
            GridView1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        string connString = "server=localhost;Integrated Security=True;database=SuperMarket";
        SqlConnection conn = new SqlConnection(connString);
        conn.Open();
        string strSql = "update  product set 价格='" + TextBox2.Text + "',名称='" + TextBox3.Text + "',库存='" + TextBox4.Text + "' where 编号='" + TextBox1.Text + "'";
        SqlCommand com = new SqlCommand(strSql, conn);
        com.ExecuteNonQuery();
        conn.Close();
        Response.Write("修改");
        GridView1.DataSourceID = "";
        GridView1.DataBind();
        GridView1.DataSource = SqlDataSource1;
        GridView1.DataBind();
    }
}
