using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] books = { "Historias de Filadelfia", "El padrino", "Sexo en Nueva York", "Tarzan de los monos" };
            var query =
                from book in books
                where book.Length > 10
                orderby book
                select new
                {
                    pepe = book.ToUpper()
                };

            List<Books> books1 = Books.GetBooks();
            var bookstitles =
                from b in books1
                select new
                {
                    Libros = b.Title,
                    Precios = b.Price
                };

            dataGridView1.DataSource = bookstitles.ToList();
        }
    }
}
