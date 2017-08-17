using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise10_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = ("Selecciona un país");
            comboBox1.Items.Add("Irlanda");
            comboBox1.Items.Add("Holanda");
            comboBox1.Items.Add("Alemania");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + " " + comboBox1.Text;
            label1.Text = dateTimePicker1.Value.Date.ToShortDateString();
        }
    }
}
