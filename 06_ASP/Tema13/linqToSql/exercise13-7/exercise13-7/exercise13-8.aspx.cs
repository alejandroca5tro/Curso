using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise13_7
{
    public partial class exercise13_8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from dc in db.Categories
                           select dc;
                GridView1.DataSource = data;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                int categoryId = Convert.ToInt32(GridView1.Rows[GridView1.SelectedIndex].Cells[0].Text);

                var data = (from dp in db.Products
                            where dp.CategoryID == categoryId
                            select dp.UnitsInStock).Sum(p => p.Value);

                TextBox1.Text = data.ToString();
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
            }
        }
    }
}