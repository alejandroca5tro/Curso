using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class exercise13_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from d in db.Customers
                           where d.City == "Sao Paulo"
                           select d.CompanyName;

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
        }
    }
}