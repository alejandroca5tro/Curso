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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Form2 form2 = new _4.Form2();
            form2.loadName(textBox1.Text, textBox2.Text);
            form2.loadAge(Convert.ToInt32(textBox3));
            form2.Show();
        }
    }
}
