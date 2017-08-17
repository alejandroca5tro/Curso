using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise13_7
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var input = new string[]
            {
                "Apple", "Banana", "Mango", "Apple", "Orange", "Mango", "Strawberry", "Apple"
            };

            var query = (from a in input
                group a by a into g
                where g.Count()>=2
                select  g.Key + "(" + g.Count() + ")").ToArray();

            GridView1.DataSource = query;
            GridView1.DataBind();
        }
    }
}