using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class exercise13_4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = db.Customers
                    .Where(d => d.City.Equals("Sao Paulo"))
                    .Select(d => d.CompanyName);

                //GridView1.DataSource = data;
                //GridView1.DataBind();

                //Otra opción:

                List<String> clientes = new List<string>();

                clientes = data.ToList();
                foreach (var item in clientes)
                {
                    Response.Write(item + "<br>");
                }
            }

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = db.Employees
                   .Where(d => d.City.Equals("London"))
                   .OrderBy(d => d.BirthDate)
                   .Select(d => new {
                        Name = d.FirstName + ' ' + d.LastName,
                        d.BirthDate
                    });                      
                   
                GridView2.DataSource = data;
                GridView2.DataBind();

            }

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = db.Products
                    .Where(d => d.UnitPrice > 50)
                    .Select(d => new
                    {
                        d.ProductName,
                        d.UnitsInStock
                    });

                //GridView3.DataSource = data;
                //GridView3.DataBind();

                //Otra opción

                foreach (var item in data)
                {
                    Response.Write(item.ProductName + "(" + item.UnitsInStock + ") <br>");
                }

            }
        }
    }
}