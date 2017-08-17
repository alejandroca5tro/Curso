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

namespace exercise10_12
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=T06W04\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void loadCombo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectCommand = "select SupplierId, CompanyName from Suppliers";
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow row = table.NewRow();
                row["CompanyName"].Equals(String.Empty);
                row["SupplierId"] = 0;
                table.Rows.Add(row);

                comboBox1.DisplayMember = table.Columns[1].ColumnName;
                comboBox1.ValueMember = table.Columns[0].ColumnName;
                table.DefaultView.Sort = table.Columns[1].ColumnName;
                comboBox1.DataSource = table;
            }
        }

        private void loadGrid(int supplierCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                string selectCommand = "select ProductName, QuantityPerUnit, UnitPrice, UnitsInStock from Products where SupplierID = @Code";
                SqlCommand selectCommand2 = new SqlCommand(selectCommand, connection);
                selectCommand2.Parameters.AddWithValue("@Code", supplierCode);
                adapter.SelectCommand = selectCommand2;

                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(comboBox1.SelectedValue);
            loadGrid(value);
        }
    }
}
