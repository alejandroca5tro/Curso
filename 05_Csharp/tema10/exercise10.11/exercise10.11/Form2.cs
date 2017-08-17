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

namespace exercise10._11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void loadCombo(string c)
        {
            string connectionString = @"Data Source=T06W04\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand selectCommand = new SqlCommand("select OrderID, Freight from Orders where CustomerID = @Codigo", connection);
                selectCommand.Parameters.AddWithValue("@Codigo", c);
                adapter.SelectCommand = selectCommand;

                DataTable table = new DataTable();
                adapter.Fill(table);
                table.DefaultView.Sort = table.Columns[1].ColumnName;

                comboBox1.DisplayMember = table.Columns[1].ColumnName;
                comboBox1.ValueMember = table.Columns[0].ColumnName;

                comboBox1.DataSource = table;
                comboBox1.SelectedItem = comboBox1.Items.Count - 1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedValue.ToString();
            textBox2.Text = comboBox1.Text; 
        }
    }
}
