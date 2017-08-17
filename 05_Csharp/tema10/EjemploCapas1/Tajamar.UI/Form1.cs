using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tajamar.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DataTable tabla = Negocio.Empleado.RecuperarTodosEmpleados(1);
                comboBox1.DisplayMember = tabla.Columns[1].ColumnName;
                comboBox1.ValueMember = tabla.Columns[0].ColumnName;
                comboBox1.DataSource = tabla;
                //Ir a la base de datos y recuperar empleados
                //combobox1.valuemember
                //combobox1.displaymember
                //cargar la combo
            }
        }
    }
}
