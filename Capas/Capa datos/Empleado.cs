using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller.Capas.Capa_datos;
namespace ProyectoTaller.Capas.Capa_datos
{
    public class Empleado
    {

        public int Cod_Empleado { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
        public int ID_perfil { get; set; }
        public int Estado { get; set; }
    }
}
