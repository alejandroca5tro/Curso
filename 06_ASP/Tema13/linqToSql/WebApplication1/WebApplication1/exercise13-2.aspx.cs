using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class exercise13_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //var data = from d in db.Employees
                //           orderby d.BirthDate
                //           where d.City == "London"
                //           select new
                //           {
                //               Name = d.FirstName + ' ' + d.LastName,
                //               d.BirthDate
                //           };

                //GridView1.DataSource = data;
                //GridView1.DataBind();

                //Otra opción:

                var data = (from d in db.Employees
                           orderby d.BirthDate
                           where d.City == "London"
                           select new
                           {
                               Name = d.FirstName + ' ' + d.LastName,
                               d.BirthDate
                           }).ToList();            

      
                foreach (var item in data)
                {
                    Response.Write(item.Name + "<br>");
                    Response.Write(Convert.ToDateTime(item.BirthDate).ToShortDateString() + "<br>");
                }
            }
        }
    }
}