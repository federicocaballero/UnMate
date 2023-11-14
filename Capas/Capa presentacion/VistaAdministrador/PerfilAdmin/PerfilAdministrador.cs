using ProyectoTaller.Capas.Capa_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.PerfilAdmin
{
    public partial class PerfilAdministrador : Form
    {
        public PerfilAdministrador()
        {
            InitializeComponent();
        }

        private void PerfilAdministrador_Load(object sender, EventArgs e)
        {
            if (DatosSesion.EmpleadoLogeado != null)
            {
                Empleado empleado = DatosSesion.EmpleadoLogeado;
                TNomyApe.Text = empleado.Nombre + " " + empleado.Apellido;
                TTelefono.Text = empleado.Telefono;
                TEmail.Text = empleado.Email;
                TDni.Text = empleado.DNI.ToString();
            }
        }
    }
}
