using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemploIniObj2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public class Student
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int[] scores { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {


            string aString = "ABCDE99F-374-12-89A";

            IEnumerable<char> stringQuery =
                from c in aString
                where Char.IsDigit(c)
                select c;

            foreach (char c in stringQuery)
            {
                Response.Write(c + " ");
                Response.Write("<br>");
            }



            //Comienzo ejemplo01
            //ArrayList arrList = new ArrayList();
            //arrList.Add(
            //    new Student
            //    {
            //        firstName = "Svetlana",
            //        lastName = "Omelchenko",
            //        scores = new int[] { 89, 92, 81, 60 }                
            //    });
            //arrList.Add(
            //    new Student
            //    {
            //        firstName = "John",
            //        lastName = "Doe",
            //        scores = new int[] { 100, 100, 100, 50 }
            //    });
            //arrList.Add(
            //    new Student
            //    {
            //        firstName = "Steve",
            //        lastName = "O'Donell",
            //        scores = new int[] { 75, 84, 91, 39 }
            //    });
            //arrList.Add(
            //    new Student
            //    {
            //        firstName = "Sven",
            //        lastName = "Mortensen",
            //        scores = new int[] { 97, 89, 85, 82 }
            //    });
            //arrList.Add(
            //    new Student
            //    {
            //        firstName = "César",
            //        lastName = "García",
            //        scores = new int[] { 97, 94, 81, 69 }
            //    });

            //var query = from Student student in arrList
            //            where student.scores[0] > 95
            //            select student;

            //foreach(Student s in query)
            //{
            //    Response.Write(s.firstName + " " + s.lastName + ":" + s.scores[0]);
            //    Response.Write("<br>");
            //}
            //fin ejemplo 01





            //comienzo ejemplo001
            //List < int > lista = new List<int>();
            //lista.Add(1);
            //lista.Add(27);
            //lista.Add(43);

            //foreach (int valores in lista)
            //{
            //    Response.Write(valores);
            //}

            //var cont = 0;



            //var person = new ejemploIniObj2.Person { firstName = "John", lastName = "Doe", age = 50 };

            //List<Person> listapersonas = new List<Person>();

            //List<Person> amigos = new List<Person>()
            //{
            //    new Person { firstName = "Andrés", lastName = "Jiménez", age = 34 },
            //    new Person { firstName = "Ana", lastName = "Rodríguez", age = 36 },
            //    new Person { firstName = "Eva", lastName = "Luna", age = 34 },
            //};

        }
        //fin ejemplo 001

            //comienzo ejemplo otro

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] fiboNumbers = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            var data = from n in fiboNumbers
                       where n % 2 == 0
                       select n;

            List<int> lista = data.ToList();

            for (int i = 0; i < lista.Count; i++)
            {
                Response.Write(lista[i]);
                Response.Write("</br>");
            }
        }
        //fin ejemplo otro
    }
}