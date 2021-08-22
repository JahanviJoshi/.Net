using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace statemanagemnet
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Persistance"] != null)
            {
                Label1.Text = Request.Cookies["Persistance"].Value;

            }
            else
                Label1.Text = "";
            if (Request.Cookies["NonPersistance"] != null)
                Label2.Text = Request.Cookies["NonPersistance"].Value;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*Persistance Cookies*/
            HttpCookie aCookieValPar = new HttpCookie("Persistance");
            aCookieValPar.Value = "This is a Persistance Cookie";
            aCookieValPar.Expires = DateTime.Now.AddSeconds(10);
            Response.Cookies.Add(aCookieValPar);


            /*Non persistance cookie*/
            HttpCookie aCookieValNonPar = new HttpCookie("NonPersistance");
            aCookieValNonPar.Value = "This is non persistance cookie";
            Response.Cookies.Add(aCookieValNonPar);
        }
    }
}