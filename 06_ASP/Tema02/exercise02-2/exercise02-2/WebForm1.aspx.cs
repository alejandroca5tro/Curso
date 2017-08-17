using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise02_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<int> lista = new List<int>();
            lista.Add(24);
            lista.Add(2);
            lista.Add(13);
            lista.Add(2);

            var data = from n in lista
                where n == 2
                select n;

            var data1 = (from n in lista
                        where n == 2
                        select n).FirstOrDefault();

            var operacion = from n in lista
                            select n;

            int suma = operacion.Sum();
            var minimo = operacion.Min();
            var maximo = operacion.Max();

            decimal media = Convert.ToDecimal(operacion.Average());
        }
    }
}