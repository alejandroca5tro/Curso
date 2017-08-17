using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise10_7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=T06W04\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;

            dataGridView1.ColumnCount = 3;
            dataGridView1.ColumnHeadersVisible = true;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Blue;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView1.Columns[0].Name = "idEmpleado";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "Apellido";

            command.Connection = connection;
            command.CommandText = "select * from Employees where City='London'";
            command.CommandType = CommandType.Text;

            connection.Open();

            dataGridView1.Rows.Clear();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                int line = dataGridView1.Rows.Add();

                dataGridView1.Rows[line].Cells["IdEmpleado"].Value = reader.GetInt32(reader.GetOrdinal("EmployeeId")).ToString();

                dataGridView1.Rows[line].Cells["Nombre"].Value = reader.GetString(reader.GetOrdinal("FirstName")).ToString();

                dataGridView1.Rows[line].Cells["Apellido"].Value = reader.GetString(reader.GetOrdinal("LastName")).ToString();
            }
        }
    }
}
