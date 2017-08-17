using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    //El sistema tendrá una clase base llamada ANIMAL
    public class ANIMAL
    {
        //con las siguientes características:
        //Atributos:
        //Clase a la que pertenece : León, Águila, Abeja, etc(String)
        protected string kind;

        //Nombre del Animal : Simba, Maya, Rintintin, etc. (String)
        protected string name;

        //Peso(double)
        protected double weight;

        //Jaula en la que el animal es asignado(int)
        protected int cage;

        //Métodos:
        //Ingresar en el zoo : Constructor
        public ANIMAL(string k, string n, double w, int c, string q)
        {
            this.kind = k;
            this.name = n;
            this.weight = w;
            this.cage = c;

            string query = q;

            string connectionString = @"Data Source=T06W04\SQLEXPRESS;Initial Catalog=Zoo;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                
                connection.Open();
                SqlCommand insertCommand = new SqlCommand(query, connection);
                insertCommand.Parameters.AddWithValue("@AnimalKind", k);
                insertCommand.Parameters.AddWithValue("@AnimalName", n);
                insertCommand.Parameters.AddWithValue("@AnimalWeight", w);
                insertCommand.Parameters.AddWithValue("@Cage", c);
                dataAdapter.InsertCommand = insertCommand;
                int affectedRows = dataAdapter.InsertCommand.ExecuteNonQuery();
                //connection.Close();
            }
        }

        //Imprimir ficha
        public virtual void printSheet()
        {
            //(por ejemplo sería ):
            //CLASE ANIMAL : León
            string kind = this.kind;
            Console.WriteLine("CLASE ANIMAL: {0}", kind);

            //o NOMBRE ANIMAL : Simba
            string name = this.name;
            Console.WriteLine("NOMBRE ANIMAL: {0}", name);

            //o PESO : 200 kg,
            double weight = this.weight;
            Console.WriteLine("PESO: {0} kg", weight.ToString());

            //o JAULA : 32
            int cage = this.cage;
            Console.WriteLine("JAULA: {0}", cage.ToString());
        }



    }
}
