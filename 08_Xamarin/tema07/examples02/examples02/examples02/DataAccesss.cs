using examples02;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examples02
{
    class DataAccesss : IDisposable
    {
        private SQLiteConnection connection;
        public DataAccesss()
        {
            var config = DependencyService.Get<IConfig>();
            connection = new SQLiteConnection(config.Plataforma, Path.Combine(config.DirectorioDB, "Empleados.db3"));
            connection.CreateTable<Employee>();
        }

        public void InsertEmployee(Employee employee)
        {
            connection.Insert(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            connection.Update(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            connection.Delete(employee);
        }

        public Employee GetEmployee(int idEmployee)
        {
            return connection.Table<Employee>().FirstOrDefault(c => c.Id == idEmployee);
        }

        public List<Employee> GetEmployees()
        {
            var list = connection.Table<Employee>().Select(c => c).OrderBy(c => c.Name).ToList();
            return list;
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
