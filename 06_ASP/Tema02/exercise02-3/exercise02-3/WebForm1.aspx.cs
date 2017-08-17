using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise02_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] Birds = { "Indigo Bunting", "Rose Breasted Grosbeak", "Robin", "House Finch", "Gold Finch", "Ruby Throated Hummingbird", "Rufous Hummingbird", "Downy Woodpecker" };

            var list = from b in Birds
                       where b.StartsWith("R")
                       select b;

            //StringBuilder sb = new StringBuilder();
            //foreach(string s in list)
            //{
            //    sb.Append(s + "<br>");
            //}
            //Response.Write("<b>Con R:</b>" + "<br>");
            //Response.Write(sb.ToString());

            var list2 = (from b in Birds
                        where b == "Gold Finch"
                        select b).FirstOrDefault();
            
            if (list2 != "")
            {

            }

            var list3 = from b in Birds
                        orderby b ascending
                        select b;

            StringBuilder sb1 = new StringBuilder();
            foreach (string s in list3)
            {
                sb1.Append(s + "<br>");
            }
            Response.Write("<b>Ordenado:</b>" + "<br>");
            Response.Write(sb1.ToString());

        }
    }
}