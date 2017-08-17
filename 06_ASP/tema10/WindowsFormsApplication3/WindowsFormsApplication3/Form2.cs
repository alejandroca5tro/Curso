using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string CalculateSalary()
        {
            int salary = Convert.ToInt32(txtHours.Text)* Convert.ToInt32(txtPriceH.Text);
            return salary.ToString();
        }

    }
}
