using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = "";
            if (checkBox1.Checked)
            {
                Text = Text + ("Inglés");
            }
            if (checkBox2.Checked)
            {
                Text = Text + ("Francés");
            }
            if (checkBox3.Checked)
            {
                Text = Text + ("Alemán");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Width = 640;
                Height = 480;
            }
            if (radioButton2.Checked)
            {
                Width = 800;
                Height = 600;
            }
            if (radioButton3.Checked)
            {
                Width = 1024;
                Height = 768;
            }
        }
    }
}
