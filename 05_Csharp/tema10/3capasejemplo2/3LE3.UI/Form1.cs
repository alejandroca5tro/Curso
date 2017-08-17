using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3LE3.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Negocio.Producto.obtener_Productos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            DataTable table = Negocio.Producto.obtenerProductoyCantidad(id);

            if (table != null)
            {
                textBox1.Text = table.Rows[0][0].ToString();
                textBox2.Text = table.Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("Stock Insuficiente", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
