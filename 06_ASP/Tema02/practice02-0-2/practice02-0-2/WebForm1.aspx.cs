using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practice02_0_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public class Contact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public DateTime DateOfBirth { get; set; }       
            public string State { get; set; }
        }

        public static List<Contact> createContactList()
        {
            List<Contact> contacts = new List<Contact>();

            Contact c1 = new Contact();
            c1.FirstName = "Pepe";
            c1.LastName = "López";
            c1.Email = "plopez@gmail.com";
            c1.Phone = "99512341234";
            c1.DateOfBirth = new DateTime(1989, 7, 28);
            c1.State = "Alabama";
            contacts.Add(c1);

            Contact c2 = new Contact();
            c2.FirstName = "María";
            c2.LastName = "Gópez";
            c2.Email = "mgomez@gmail.com";
            c2.Phone = "88512343234";
            c2.DateOfBirth = new DateTime(1984, 8, 15);
            c2.State = "Boston";
            contacts.Add(c2);

            Contact c3 = new Contact();
            c3.FirstName = "Javier";
            c3.LastName = "Barrero";
            c3.Email = "jbv@gmail.com";
            c3.Phone = "39516541234";
            c3.DateOfBirth = new DateTime(1985, 5, 5);
            c3.State = "Washington";
            contacts.Add(c3);

            Contact c4 = new Contact();
            c4.FirstName = "Verónica";
            c4.LastName = "Gutiérrez";
            c4.Email = "vegutie@gmail.com";
            c4.Phone = "99517895534";
            c4.DateOfBirth = new DateTime(1987, 1, 4);
            c4.State = "Alabama";
            contacts.Add(c4);

            Contact c5 = new Contact();
            c5.FirstName = "Álvaro";
            c5.LastName = "Andújar";
            c5.Email = "plopez@gmail.com";
            c5.Phone = "59512236534";
            c5.DateOfBirth = new DateTime(1988, 4, 24);
            c5.State = "Miami";
            contacts.Add(c5);

            Contact c6 = new Contact();
            c6.FirstName = "Luis";
            c6.LastName = "Peinado";
            c6.Email = "lpeindao@gmail.com";
            c6.Phone = "32512341456";
            c6.DateOfBirth = new DateTime(1989, 8, 2);
            c6.State = "Texas";
            contacts.Add(c6);

            Contact c7 = new Contact();
            c7.FirstName = "Daniel";
            c7.LastName = "Canto";
            c7.Email = "danielcanto@gmail.com";
            c7.Phone = "14512895234";
            c7.DateOfBirth = new DateTime(1983, 5, 25);
            c7.State = "Virginia";
            contacts.Add(c7);         

            Contact c8 = new Contact();
            c8.FirstName = "Francisco";
            c8.LastName = "López";
            c8.Email = "flopez@gmail.com";
            c8.Phone = "45512312354";
            c8.DateOfBirth = new DateTime(1982, 2, 28);
            c8.State = "Colorado";
            contacts.Add(c8);

            Contact c9 = new Contact();
            c9.FirstName = "Inma";
            c9.LastName = "Rojas";
            c9.Email = "irojas@gmail.com";
            c9.Phone = "25812341456";
            c9.DateOfBirth = new DateTime(1988, 8, 21);
            c9.State = "Georgia";
            contacts.Add(c9);

            Contact c10 = new Contact();
            c10.FirstName = "Samuel";
            c10.LastName = "Domínguez";
            c10.Email = "samueld@gmail.com";
            c10.Phone = "95512345434";
            c10.DateOfBirth = new DateTime(1985, 4, 25);
            c10.State = "Alabama";
            contacts.Add(c10);

            return contacts;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Contact> contacts = createContactList();
                        
            var list = from c in contacts
                       orderby c.LastName ascending
                       select c;
            //Lambda:
            //var listaLambda = list
            //    .OrderBy(n => list);

            Response.Write("<b>Contactos ordenados por segundo apellido:</b>" + "<br>");
            foreach (Contact c in list)
            {
                Response.Write(c.FirstName + " " + c.LastName + "<br/>");
            }    
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<Contact> contacts = createContactList();

            var list = from c in contacts
                       where c.FirstName.StartsWith("J")
                       select c;

            //Lamda:
            //var listaLambda = list
            //    .Where(n => n.FirstName.StartsWith("A"))
            //    .Select(n => n.FirstName + " " + n.LastName + " " + "Tlf:" + n.Phone);  
            Response.Write("<b>Contactos que comienzan por 'J':</b>" + "<br>");
            foreach (Contact c in list)
            {
                Response.Write(c.FirstName + " " + c.LastName + " Teléfono: "+ c.Phone + "<br/>");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            List<Contact> contacts = createContactList();

            var list = (from c in contacts
                       where c.Email == "irojas@gmail.com"
                       select c).FirstOrDefault();

            //Lambda
            //var listaLambda = contacts
            //    .Where(n => n.Email == "irojas@gmail.com")
            //    .Select(n => n.Phone)
            //    .FirstOrDefault();

            Response.Write("<b>Teléfono del contacto cuyo email es igual a ‘irojas@gmail.com:</b>" + "<br>");  
       
            Response.Write(list.FirstName + " " + list.LastName + " Teléfono: " + list.Phone + "<br/>");
     
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            List<Contact> contacts = createContactList();

            var list = from tf in contacts
                       where tf.Phone.StartsWith("9")
                       && tf.State == "Alabama"
                       select tf;

            //Lambda:
            var t9Alabama = contacts
                .Where(n => n.Phone.StartsWith("9") && n.State == "Alabama")
                .Select(n => n.LastName + " " + n.FirstName + " Teléfono: " + c.Phone + "<br/>");

            Response.Write("<b>Contactos del estado “Alabama” y cuyo teléfono comience por 9:</ b>" + "<br>");
            foreach (Contact c in list)
            {
                Response.Write(c.FirstName + " " + c.LastName + " Teléfono: " + c.Phone + "<br/>");
            }
        }
    }
}