using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargar_datos();
            cargar_grid();
        }

        private void cargar_grid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Teléfono");

            using (var context = new Model1Container())
            {
                foreach (var empleado in context.PersonaSet)
                {
                    crear_fila(dt, empleado.Id, empleado.FirstName, empleado.LastName, empleado.PhoneNumber);
                }

                //De un ejercicio anterior:
                //var person1 = new Persona
                //{
                //    FirstName = "John",
                //    LastName = "Doe",
                //    PhoneNumber = "244-434324"
                //};
                //context.PersonaSet.Add(person1);

                //var person2 = new Persona
                //{
                //    FirstName = "Jina",
                //    LastName = "Doe",
                //    PhoneNumber = "244-434324"
                //};
                //context.PersonaSet.Add(person2);

                //context.SaveChanges();
            }
        }

        private void crear_fila(DataTable dt, int idPersona, string firstName, string lastName, string phone)
        {
            DataRow fila;
            fila = dt.NewRow();

            fila["Id"] = idPersona;
            fila["Nombre"] = firstName;
            fila["Apellidos"] = lastName;
            fila["Teléfono"] = phone;
            dt.Rows.Add(fila);      
        }

        private void cargar_datos()
        {
            throw new NotImplementedException();
        }
    }
}