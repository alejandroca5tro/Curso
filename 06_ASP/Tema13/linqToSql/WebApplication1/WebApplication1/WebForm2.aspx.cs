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
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = (from d in db.Customers
                            where d.Country == "Spain"
                            select d).SelectMany(d => d.Orders).ToList();

                var data2 =
                    (from d in db.Order_Details
                     where d.OrderID.Equals(10250)
                     select d.Quantity * d.UnitPrice).Sum();

            }
        }
    }
}