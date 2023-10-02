
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionProductos;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.PerfilAdmin;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador;
using ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor;
using ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.GestionProveedores;
using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor;
namespace ProyectoTaller
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
