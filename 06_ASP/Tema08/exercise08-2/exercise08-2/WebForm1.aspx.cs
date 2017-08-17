using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise08_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Provincias");
            dt.Columns.Add("ProvinciaID", typeof(int));
            dt.Columns.Add("ProvinciaDes", typeof(string));
            DataRow row1 = dt.NewRow();
            row1["ProvinciaID"] = 8;
            row1["ProvinciaDes"] = "Barcelona";
            dt.Rows.Add(row1);

            DataRow row2 = dt.NewRow();
            row2["ProvinciaID"] = 28;
            row2["ProvinciaDes"] = "Madrid";
            dt.Rows.Add(row2);

            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);

            if (currentRows.Length > 1)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    Response.Write("<strong>" + column.ColumnName + "</strong>  ");
                }
                Response.Write("<br>");

                foreach (DataRow row in currentRows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        Response.Write(row[column] + " ");
                    }
                    Response.Write("<br>");
                }
            }

            Response.Write("<br>Mediante DataView<br>");
            DataView provincias = new DataView(dt, null, null, DataViewRowState.CurrentRows);
            foreach (DataRowView rowview in provincias)
            {
                DataRow row = rowview.Row;
                foreach (DataColumn column in dt.Columns)
                {
                    Response.Write(row[column] + " ");
                }
                Response.Write("<br>");
            }
        }
    }
}