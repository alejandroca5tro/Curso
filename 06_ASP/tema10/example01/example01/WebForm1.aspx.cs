using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace example01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    if (e.CommandName.Equals("Print"))
        //    {
        //        int index = Convert.ToInt32(e.CommandArgument);
        //        GridViewRow fila = GridView1.Rows[index];

        //        TableCell company = fila.Cells[1];
        //        string companyName = company.Text;

        //        Response.Write("<br>" + companyName + "<br>");
        //    }
        //}
    }
}