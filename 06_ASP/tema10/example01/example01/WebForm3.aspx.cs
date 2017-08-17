using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace example01
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Deleting(object sender, SqlDataSourceCommandEventArgs e)
        {
            if (! DropDownList1.SelectedValue.Equals("2"))
            {
                e.Cancel = true;
                Label1.Text = "Comando cancelado porque no cumple el Rol de Administrador";
                Label1.Visible = true;
            }
        }

        protected void SqlDataSource1_Deleted(object sender, SqlDataSourceStatusEventArgs e)
        {
            Label1.Visible = true;
            Label1.Text = e.AffectedRows.ToString() + "filas han sido afectadas";
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Seleccionar_Index")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow fila = GridView1.Rows[index];
                TableCell producto = fila.Cells[1];
                TableCell precio = fila.Cells
            }
        }
    }
}