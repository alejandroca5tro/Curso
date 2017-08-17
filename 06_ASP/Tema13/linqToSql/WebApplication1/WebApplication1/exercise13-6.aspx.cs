using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class exercise13_6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = (from dE in db.Employees
                           join dO in db.Orders on dE.EmployeeID equals dO.EmployeeID
                           join dOD in db.Order_Details on dO.OrderID equals dOD.OrderID
                           where dE.EmployeeID == 6
                           select dOD.UnitPrice * dOD.Quantity).Average().ToString();

                Response.Write(data);
            }
        }
    }
}