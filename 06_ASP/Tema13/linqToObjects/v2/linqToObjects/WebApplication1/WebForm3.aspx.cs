using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var books2 =
                Books.GetBooks()
                .Select((book, index) => new
                {
                    index,
                    book.Title
                })
                .OrderByDescending (book => book.Title);

            var autores =
                (from book in Books.GetBooks()
                 select new
                 {
                     Author = book.Author
                 }).Distinct();

            var autores1 =
                Books.GetBooks()
                .Select(b => b.Author)
                .Distinct();
                
            GridView1.DataSource = books2.ToList();
            GridView1.DataBind();
        }
    }
}