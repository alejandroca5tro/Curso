using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise05_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string studentName
        {
            get
            {
                return txtStudent.Text.ToString();
            }
        }

        public string subject1Score
        {
            get
            {
                return txtSubject1.Text;
            }
        }

        public string subject2Score
        {
            get
            {
                return txtSubject2.Text;
            }
        }

        public string subject3Score
        {
            get
            {
                return txtSubject3.Text;
            }
        }



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm2.aspx");
        }
    }
}