using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            lblRes.Text = "Ola k ase";
            lblRes.Visible = true;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtBox1.Text)>20)
            {
                MessageBox.Show("Número mayor que 20",
                    "Cuidadín pecador",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1
                    );
            }
            else
            {
                lblRes.Text = (Convert.ToInt32(txtBox1.Text) + Convert.ToInt32(txtBox2.Text)).ToString();
                lblRes.Visible = true;
            }            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox1.Text))
            {
                if (!Regex.IsMatch(txtBox1.Text,@"[\p{L}\s]"))
                {
                    MessageBox.Show("Formato Correcto");
                }
                else
                {
                    MessageBox.Show("No es un número");
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar la caja");
            }

            //lblRes.Text = (Convert.ToInt32(txtBox1.Text) - Convert.ToInt32(txtBox2.Text)).ToString();
            //lblRes.Visible = true;
        }

        private void lblRes_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres borrar el registro de empleado?", "Delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result.Equals(DialogResult.OK))
            {
                MessageBox.Show("Borrando registro.......");
            }
            else
            {
                MessageBox.Show("Back........");
            }
        }
    }
}
