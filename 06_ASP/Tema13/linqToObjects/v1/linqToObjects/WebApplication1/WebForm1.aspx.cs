using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] words = { "hola", "adiós", "buenas", "noches" };

            //foreach (string word in words)
            //{
            //    if(word.Length <= 5)
            //    {
            //        Response.Write(word);
            //        Response.Write("<br>");
            //    }
            //}

            var shortWords =
                from word in words
                where word.Length <= 5
                select word;

            foreach (var word in shortWords)
            {
                Response.Write(word);
                Response.Write("<br>");
            }
        }
    }
}