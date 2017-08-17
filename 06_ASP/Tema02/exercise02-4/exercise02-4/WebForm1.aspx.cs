using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise02_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public class Parts
        {
            public int PartNumber { get; set; }
            public string PartDescription { get; set; }
        }

        public static List<Parts> CrearLista()
        {
            List<Parts> parts = new List<Parts>();

            Parts p1 = new Parts();
            p1.PartNumber = 1;
            p1.PartDescription = "Cog";
            parts.Add(p1);

            Parts p2 = new Parts();
            p2.PartNumber = 1;
            p2.PartDescription = "Widget";
            parts.Add(p2);

            Parts p3 = new Parts();
            p3.PartNumber = 1;
            p3.PartDescription = "Gear";
            parts.Add(p3);

            Parts p4 = new Parts();
            p4.PartNumber = 1;
            p4.PartDescription = "Tank";
            parts.Add(p4);

            return parts;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Parts> datos = CrearLista();

            var list = from d in datos
                       orderby d.PartNumber ascending
                       select d;

            //expresiones lambda
            var list1 = datos
                .OrderBy(d => d.PartNumber);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<Parts> datos = CrearLista();

            var matchingParts = from m in datos
                                where m.PartDescription.StartsWith("S")
                                select m;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            List<Parts> datos = CrearLista();
            var query = (from m in datos
                         where m.PartNumber.Equals(5)
                         select m.PartDescription).Single<string>();
        }
    }
}