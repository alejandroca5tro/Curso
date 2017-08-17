using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise04_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string concatenarNombre()
        {
            string nombreCompleto =
                txtNombre.Text + " " + txtApellido.Text;

            return nombreCompleto;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string opcion = "";
            if (chkNet.Checked)
            {
                opcion += chkNet.Text + " ";
            }
            if (chkPhp.Checked)
            {
                opcion += chkNet.Text + " ";
            }
            if (chkJava.Checked)
            {
                opcion += chkNet.Text + " ";
            }

            Response.Write(concatenarNombre() + " " + opcion);
        }
    }
}