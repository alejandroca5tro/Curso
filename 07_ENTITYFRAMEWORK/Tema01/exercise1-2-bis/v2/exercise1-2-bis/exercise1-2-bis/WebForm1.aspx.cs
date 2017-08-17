using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise1_2_bis
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var context = new Model1Container())
            {
                var customers = from dc in context.CustomersSet
                                select new
                                {
                                    Name = dc.CompanyName,
                                    Id = dc.Id
                                };

                Customers.DataSource = customers.ToList();
                Customers.DataBind();
            }
        }
    }
}