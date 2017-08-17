using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise13_7
{
    public partial class exercise13_10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Shipper sp = new Shipper();
                sp.CompanyName = "Compañía añadida";
                sp.Phone = "Teléfono añadido";
                db.Shippers.InsertOnSubmit(sp);
                db.SubmitChanges();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var dato = db.Shippers.SingleOrDefault(s => s.ShipperID.Equals(4));
                if (dato != null)
                {
                    //db.Shippers.
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
              
            }
        }
    }
}