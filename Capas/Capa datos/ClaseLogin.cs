using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller.Capas.Capa_presentacion;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador;
using ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor;
using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor;
using System.Data.SqlClient;
using System.Net;
using ProyectoTaller.Capas.Capa_datos;
using System.Security.Policy;

namespace ProyectoTaller.Capas.Capa_datos
{
    internal class ClaseLogin
    {
        SqlConnection Logearse = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;");

        private Empleado empleadoLogeado;
        public Form FormularioActual { get; set; }


        public Empleado IniciarSesion(string dni, string contraseña)
        {
            Empleado empleadoLogeado = null;

           
                using (SqlConnection Logearse = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
                {
                    Logearse.Open();

                    string consultaLogeo = "SELECT * FROM Empleado WHERE DNI = @DNI AND Estado = 1;";
                    SqlCommand consulta = new SqlCommand(consultaLogeo, Logearse);
                    consulta.Parameters.AddWithValue("@DNI", dni);

                    using (SqlDataReader reader = consulta.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            string contraseñaAlmacenada = reader["Contraseña"].ToString();

                        try
                        {
                            //tuvimos que realizar la otra condicion debido a que no nos funcionaba solo con verify
                            if (contraseña == contraseñaAlmacenada || BCrypt.Net.BCrypt.Verify(contraseña, contraseñaAlmacenada))
                            {
                                empleadoLogeado = new Empleado
                                {
                                    Cod_Empleado = Convert.ToInt32(reader["Cod_Empleado"]),
                                    DNI = Convert.ToString(reader["DNI"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Contraseña = contraseñaAlmacenada,
                                    Telefono = reader["Telefono"].ToString(),
                                    ID_perfil = Convert.ToInt32(reader["ID_perfil"]),
                                    Estado = Convert.ToInt32(reader["Estado"])
                                };
                            }
                           
                        }
                        catch (BCrypt.Net.SaltParseException)
                        {
                            
                        }

                    }

                }
                if (empleadoLogeado != null)
                    {
                        int tipoPerfil = empleadoLogeado.ID_perfil;
                        Form formulario = null;

                        switch (tipoPerfil)
                        {
                            case 1:
                                DatosSesion.EmpleadoLogeado = empleadoLogeado;
                                break;
                            case 2:
                                formulario = new MenuVendedor();
                                DatosSesion.EmpleadoLogeado = empleadoLogeado;
                                break;
                            case 3:
                                formulario = new MenuSupervisor();
                                DatosSesion.EmpleadoLogeado = empleadoLogeado;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas o empleado inactivo.", "Error en iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            return empleadoLogeado;
        }




        public void ErroresMarcados(TextBox TBDniUsuario, TextBox TBContraseña, ErrorProvider errorProvider)
        {
            if (TBContraseña.Text == "")
            {
                // establecer un mensaje de error para el control contraseña
                errorProvider.SetError(TBContraseña, "Contraseña obligatoria");
            }
            else
            {
                //quitar el error provider
                errorProvider.SetError(TBContraseña, "");
            }
            if (TBDniUsuario.Text == "")
            {
                // establecer un mensaje de error para el control TBUsuario
                errorProvider.SetError(TBDniUsuario, "DNI obligatorio");
            }
            else
            {
                //quitar el error provider
                errorProvider.SetError(TBDniUsuario, "");
            }
        }

        public void SalirAplicacion()
        {
            DialogResult result = MessageBox.Show("Desea salir de la aplicación? ", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
    }
    
   



}
