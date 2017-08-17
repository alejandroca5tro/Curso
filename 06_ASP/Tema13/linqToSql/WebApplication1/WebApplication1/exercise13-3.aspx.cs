using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class exercise13_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from d in db.Products
                           where d.UnitPrice > 50
                           select new
                           {
                               d.ProductName,
                               d.UnitsInStock
                           };

                GridView1.DataSource = data;
                GridView1.DataBind();
            }
        }
    }
}