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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loadCombo();
        }

        private void loadCombo()
        {
            string connectionString = @"Data Source=T06W04\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string selectCommand = "select CategoryId, CategoryName from Categories";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connection);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            DataRow row = table.NewRow();
            row["CategoryName"] = string.Empty;
            row["CategoryId"] = 0;
            table.Rows.Add(row);
            table.DefaultView.Sort = table.Columns[1].ColumnName;

            comboBox1.DisplayMember = table.Columns[1].ColumnName;
            comboBox1.ValueMember = table.Columns[0].ColumnName;
            comboBox1.DataSource = table;    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string value = comboBox1.SelectedValue.ToString();

            string value = comboBox1.Text;

            MessageBox.Show(value);
        }
    }
}
