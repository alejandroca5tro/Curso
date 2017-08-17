using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class exercise13_5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = (from dE in db.Employees
                           join dO in db.Orders
                           on dE.EmployeeID equals dO.EmployeeID
                           orderby dO.OrderDate, dE.LastName
                           select new
                           {
                               dO.OrderDate,
                               Name = '(' + dE.FirstName + ' ' + dE.LastName + ')'
                           }).ToList();

                Response.Write("Listado de pedidos");

                foreach (var item in data)
                {
                    Response.Write(Convert.ToDateTime(item.OrderDate).ToShortDateString() + item.Name + "<br>");
                }

                
            }
        }
    }
}