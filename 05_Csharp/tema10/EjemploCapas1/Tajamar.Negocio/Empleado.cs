using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tajamar.Negocio
{
    public class Empleado
    {
        public static DataTable RecuperarTodosEmpleados(int tipoUsuario)
        {
            if (tipoUsuario == 1)
            {
                return Datos.Empleado.RecuperarTodosEmpleados();
            }
            else
            {
                return null;
            }
        }
    }
}
