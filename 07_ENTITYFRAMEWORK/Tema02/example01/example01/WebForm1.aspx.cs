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
            using (var context = new VientoNorteEntities())
            {
                if (!IsPostBack)
                {
                    var customers = from dc in context.ClientesSet
                                    select new
                                    {
                                        Name = dc.CompanyName,
                                        Id = dc.Id
                                    };

                    Customers.DataSource = customers.ToList();
                    Customers.DataBind();


                    var products = from dp in context.ProductosSet
                                   select new
                                   {
                                       Name = dp.ProductName,
                                       Id = dp.Id
                                   };

                    Products.DataSource = products.ToList();
                    Products.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var context = new VientoNorteEntities())
            {
                //var order = from dOr in context.PedidosSet
                //            select dOr;

                int quantity = Convert.ToInt32(TextBox1.Text);
                int customerId = Convert.ToInt32(Customers.SelectedValue);
                int productId = Convert.ToInt32(Products.SelectedValue);

                var order = new PedidosSet
                {
                    Cantidad = quantity,
                    ClientesId = customerId,
                    ProductosId = productId
                };

                context.PedidosSet.Add(order);
                context.SaveChanges();

                var orderFull = from dOrF in context.PedidosSet
                                join dP in context.ProductosSet on dOrF.ProductosId equals dP.Id
                                select new
                                {
                                    Order = dOrF.Id,
                                    Product = dP.ProductName,
                                    Quantity = dOrF.Cantidad,
                                    UnitPrice = dP.UnitPrice,
                                    Total = dP.UnitPrice * dOrF.Cantidad
                                };
                
                Orders.DataSource = orderFull.ToList();
                Orders.DataBind();
            }

            
        }
    }
}