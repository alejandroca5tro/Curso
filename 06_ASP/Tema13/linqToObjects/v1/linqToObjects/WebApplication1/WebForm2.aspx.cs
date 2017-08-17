using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Book[] books = {
                new Book { Title="Linq to sql"},
                new Book { Title="Sql in action"},
                new Book { Title="Asp for all"}
            };

            var titles =
                books
                .Where(book => book.Title.Contains("Linq"))
                .Select(book => book.Title);

            GridView1.DataSource = titles.ToList();
            GridView1.DataBind();

            var titles1 =
                from b in books
                where b.Title.Contains("Linq")
                select b.Title;

            GridView1.DataSource = titles1.ToList();
            GridView1.DataBind();
        }
    }
}