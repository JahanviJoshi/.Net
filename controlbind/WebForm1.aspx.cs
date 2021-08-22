using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace controlbind
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-JCLI3CL\SQLEXPRESS;Initial Catalog= College;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter adapt;
        DataTable dt;
        DataSet ds;



        protected void Page_Load(object sender, EventArgs e)
        {
            /*string mainconn = ConfigurationManager.ConnectionStrings["CollegeConnectionString"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(mainconn);
            string sqlquery = "select name from sys.tables";
            SqlCommand cmd = new SqlCommand(sqlquery, sqlcon);
            sqlcon.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "name";
            DropDownList1.DataBind();
            sqlcon.Close();*/
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String q = "select * from " + DropDownList1.Text;
            cn.Open();
            adapt = new SqlDataAdapter(q, cn);
            dt = new DataTable();
            adapt.Fill(dt);
            GridView1.DataSource = dt;
            cn.Close();
            GridView1.DataBind();

        }
    }
}