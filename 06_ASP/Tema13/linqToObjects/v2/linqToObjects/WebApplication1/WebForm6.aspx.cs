using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewComplete.DataSource =
                SampleData.Books
                .Select((book, index) => new
                {
                    Index = index,
                    book = book.Title
                });

                GridViewComplete.DataBind();
                int count = SampleData.Books.Count();
                for (int i = 0; i < count; i++)
                {
                    dllStart.Items.Add(i.ToString());
                    dllEnd.Items.Add(i.ToString());
                }
                dllStart.SelectedIndex = 2;
                dllEnd.SelectedIndex = 3;

                DisplayPartialData();
            }            
        }

        private void DisplayPartialData()
        {
            int startIndex = int.Parse(dllStart.SelectedValue);
            int endIndex = int.Parse(dllEnd.SelectedValue);

            GridViewPartial.DataSource =
                SampleData.Books
                .Select((book, index) => new
                {
                    Index = index,
                    Book = book.Title
                })
                .Skip(startIndex)
                .Take(endIndex - startIndex + 1);

            GridViewPartial.DataBind();
        }

        protected void GridViewComplete_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewPartial.DataBind();
        }

        protected void GridViewPartial_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewPartial.DataBind();
        }
    }
}