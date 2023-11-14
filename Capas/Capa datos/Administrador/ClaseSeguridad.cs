using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_datos.Administrador
{


    internal class ClaseSeguridad
    {
        private SqlConnection AdministracionDeSeguridad;
        private Button BCopia;
        private Button BCargarCopia;
        private Button BSubirCopia;
        private TextBox txtSubir;


        public ClaseSeguridad(Button BCopia, Button BCargarCopia, Button BSubirCopia, TextBox txtSubir)
        {              
             AdministracionDeSeguridad  = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;");
            this.BCopia= BCopia;
            this.BCargarCopia= BCargarCopia;
            this.BSubirCopia= BSubirCopia;
            this.txtSubir= txtSubir;

        }


        public void crearCopiar()
        {
            string database = "UnMate";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de respaldo de SQL Server (*.bak)|*.bak";
            saveFileDialog.Title = "Guardar Respaldo de la Base de Datos";
            saveFileDialog.FileName = database + "_" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm--ss") + ".bak";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + saveFileDialog.FileName + "'";

                AdministracionDeSeguridad.Open();
                SqlCommand command = new SqlCommand(cmd, AdministracionDeSeguridad);
                command.ExecuteNonQuery();
                MessageBox.Show("Base de datos respaldada con éxito", "Respaldo completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdministracionDeSeguridad.Close();
            }
        }

        public void cargarCopia()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Archivos de respaldo de SQL Server (*.bak)|*.bak";
            dlg.Title = "Restauración de base de datos";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtSubir.Text = dlg.FileName;
                BSubirCopia.Enabled = true;
            }

        }

        public void establecerCopiar()
        {
            string database = "UnMate";
            AdministracionDeSeguridad.Open();
            

                string str2 = "ALTER DATABASE [UnMate] SET OFFLINE WITH ROLLBACK IMMEDIATE;RESTORE DATABASE [" + database + "] FROM DISK = '" + txtSubir.Text + "' WITH REPLACE; ALTER DATABASE[UnMate] SET ONLINE";
                SqlCommand cmd2 = new SqlCommand(str2, AdministracionDeSeguridad);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Base de datos restaurada con éxito", "Restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BSubirCopia.Enabled = true;txtSubir.Clear();
                BCargarCopia.Enabled = false;

                AdministracionDeSeguridad.Close();
            
        }
    }
}
