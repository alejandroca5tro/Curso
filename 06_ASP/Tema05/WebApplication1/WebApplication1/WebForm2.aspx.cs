using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string datos = "";
                datos += Request.Form["txtNombre"].ToString();
                datos += " " + Request.Form["txtApellido"].ToString();

                txtConcatenado.Text = datos;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cadena = txtConcatenado.Text;
            Response.Redirect("WebForm3.aspx?valor1="+23+"&valor2="+54);
        }
    }
}