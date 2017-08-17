using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var minPrice = Books.GetBooks()
                .Min(book => book.Price);

            var minPrice1 = (from book in Books.GetBooks()
                             select book.Price).Min();

            TextBox1.Text = minPrice.ToString();
            
        }
    }
}