using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practice02_0_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] nums = new int[] { 0, 4, 2, 6, 3, 8, 3, 1 };

            var numbers1 = from n in nums                          
                           where n < 5
                           orderby n ascending
                           select n;

            StringBuilder numP = new StringBuilder();
            foreach (int n in numbers1)
            {
                numP.Append(n.ToString() + "<br>");
            }
            Response.Write("<b>Menores de 5:</b>" + "<br>");
            Response.Write(numP.ToString());
            
            //En lambda
            var resultLambda = nums
                .Where(n => n < 5)
                .OrderBy(n => n)
                .Select(n => n);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int[] nums = new int[] { 0, 4, 2, 6, 3, 8, 3, 1 };

            var operacion = from n in nums
                            select n;

            int suma = operacion.Sum();

            Response.Write("<b>Suma total:</b>" + "<br>");
            Response.Write(suma.ToString());


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int[] nums = new int[] { 0, 4, 2, 6, 3, 8, 3, 1 };

            var numbers1 = (from n in nums                            
                            where n < 5
                            orderby n ascending
                            select n).Distinct();

            //En lambda
            var resultLambda = nums
                .Where(n => n < 5)
                .OrderBy(n => n)
                .Distinct();

            StringBuilder numP = new StringBuilder();
            foreach (int n in numbers1)
            {
                numP.Append(n.ToString() + "<br>");
            }
            Response.Write("<b>Menores de 5 sin repetir:</b>" + "<br>");
            Response.Write(numP.ToString());
        }
    }
}