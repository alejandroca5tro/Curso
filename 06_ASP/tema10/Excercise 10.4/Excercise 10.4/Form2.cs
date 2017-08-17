using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise_10._4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void loadName(string name, string lastName)
        {
            txtWholeName.Text = name + " " + lastName;
        }
        public void loadAge(int age)
        {
            int days = age * 365;
            txtDays.Text = days.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtWholeName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has hecho click");
        }

    }
}
