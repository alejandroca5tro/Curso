using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var query =
                from book in SampleData.Books
                group book by new { book.Publisher, book.Subject }
                into grouping
                select new
                {
                    Publisher = grouping.Key.Publisher.Name,
                    Subject = grouping.Key.Subject.Name
                };

            //Lambda:

            var query2 =
                SampleData.Books
                .GroupBy(b => new { b.Publisher, b.Subject })
                .Select(b => new
                {
                    Publisher = b.Key.Publisher.Name,
                    Subject = b.Key.Subject.Name
                });

            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }
    }
}