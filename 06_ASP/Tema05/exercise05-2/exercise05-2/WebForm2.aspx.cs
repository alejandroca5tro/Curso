using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise05_2
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        private double calculateAverage(int n1, int n2, int n3)
        {
            double average = (n1 + n2 + n3) / 3;

            return average;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (PreviousPage != null)
            {
                txtShowStudent.Text = PreviousPage.studentName.ToString();

                int n1 = Convert.ToInt32(PreviousPage.subject1Score);
                int n2 = Convert.ToInt32(PreviousPage.subject2Score);
                int n3 = Convert.ToInt32(PreviousPage.subject3Score);

                txtAverage.Text = calculateAverage(n1, n2, n3).ToString();
            }
            else
            {
                Response.Write("De que no");
            }
        }
    }
}