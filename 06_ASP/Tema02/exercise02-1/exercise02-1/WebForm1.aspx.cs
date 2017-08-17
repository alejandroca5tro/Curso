using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise02_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {       

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] tools = { "Tablesaw", "Bandsaw", "Planer", "Jointer", "Brill", "Bander" };

            var query = from string tool in tools
                        select tool.ToUpper();

            StringBuilder sb = new StringBuilder();

            foreach (string t in query)
            {
                sb.Append(t + "<br>");             
            }

            string res = sb.ToString();
            result.InnerHtml = res;
        }
    }
}