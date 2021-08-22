using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace linq
{
    public partial class default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            var d = new DataClasses1DataContext();
            product1 c = new product1();
            c.pname = TextBox1.Text;
            c.pprice = Convert.ToInt32(TextBox2.Text);

            d.product1s.InsertOnSubmit(c);
            d.SubmitChanges();
            Label1.Text = "Successfully Added dATA";
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var d = new DataClasses1DataContext();
            product1 c = d.product1s.FirstOrDefault(e1 => e1.pname.Equals(TextBox1.Text));
            c.pname = TextBox1.Text;
            c.pprice = Convert.ToInt32(TextBox2.Text);
            d.SubmitChanges();
            Label1.Text = "Successfully updated dATA";
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            var d = new DataClasses1DataContext();
            product1 c = d.product1s.FirstOrDefault(e1 => e1.pname.Equals(TextBox1.Text));
            d.product1s.DeleteOnSubmit(c);
            d.SubmitChanges();
            Label1.Text = "Successfully Deleted dATA";
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}