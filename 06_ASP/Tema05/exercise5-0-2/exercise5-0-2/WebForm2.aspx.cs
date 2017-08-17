using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise5_0_2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Mediante lo más básico
            //string dato1 = Request.Form["name"].ToString();
            //Label1.Text = "Name: " + dato1;

            //string dato2 = Request.Form["category"].ToString();
            //Label2.Text = "Category: " + dato2;

            //string dato3 = Request.Form["supplier"].ToString();
            //Label3.Text = "Supplier: " + dato3;

            //string dato4 = Request.Form["unitPrice"].ToString();
            //Label4.Text = "Unit Price: " + dato4;

            //Mediante Response.Redirect:

            string name = Request.QueryString["name"];
            string category = Request.QueryString["category"];
            string supplier = Request.QueryString["supplier"];
            string unitPrice = Request.QueryString["unitPrice"];

            Label1.Text = "Name: " + name;
            Label2.Text = "Category: " + category;
            Label3.Text = "Supplier: " + supplier;
            Label4.Text = "Unit Price: " + unitPrice;


            //Mediante Server.Transfer:
            //string dato1 = Request.Form["name"].ToString();
            ////int dato2 = int.Parse(Request.Form["category"]);
            //string category = Request.Form["hiddenfield"];
            //int dato3 = int.Parse(Request.Form["supplier"]);
            //string dato4 = Request.Form["unitPrice"].ToString();
        }
    }
}