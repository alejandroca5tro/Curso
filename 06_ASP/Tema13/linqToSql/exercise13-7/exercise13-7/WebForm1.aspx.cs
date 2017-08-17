using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise13_7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from dc in db.Categories
                           select new
                           {
                               Id = dc.CategoryID,
                               Name = dc.CategoryName
                           };

                Categories.DataSource = data;
                Categories.DataBind();
            }
        }

        protected void Categories_SelectedIndexChanged(object sender, EventArgs e)
        {     
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                int index = Categories.SelectedIndex;

                var data = from p in db.Products
                           where p.CategoryID == index
                           select new
                           {
                               Productos = p.ProductName                        
                           };

                Products.DataSource = data;
                Products.DataBind();
            }
        }
    }
}