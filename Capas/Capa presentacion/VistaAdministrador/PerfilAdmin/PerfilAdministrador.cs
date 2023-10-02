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

        private void Desloqueado()
        {
            TNomyApe.Enabled = true;
            TTelefono.Enabled = true;
            TDni.Enabled = true;
            TEmail.Enabled = true;
            TBusuario.Enabled = true;
            TDepto.Enabled = true;
            TCalle.Enabled = true;
            TCodigo.Enabled = true;
            TPiso.Enabled = true;
            TProvincia.Enabled = true;
            TLocalidad.Enabled = true;

        }

        private void Bloqueado()
        {
            TNomyApe.Enabled = false;
            TTelefono.Enabled = false;
            TDni.Enabled = false;
            TEmail.Enabled = false;
            TBusuario.Enabled = false;
            TDepto.Enabled = false;
            TCalle.Enabled = false;
            TCodigo.Enabled = false;
            TPiso.Enabled = false;
            TProvincia.Enabled = false;
            TLocalidad.Enabled = false;
        }


        private void TBusuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TNomyApe_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void TDni_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TEmail_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TProvincia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TLocalidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TCodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TDepto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TPiso_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TNomyApe.Text) && !String.IsNullOrWhiteSpace(TTelefono.Text) && !String.IsNullOrWhiteSpace(TDni.Text) && !String.IsNullOrWhiteSpace(TEmail.Text) && !String.IsNullOrWhiteSpace(TBusuario.Text)
               && !String.IsNullOrWhiteSpace(TDepto.Text) && !String.IsNullOrWhiteSpace(TCalle.Text) && !String.IsNullOrWhiteSpace(TCodigo.Text) && !String.IsNullOrWhiteSpace(TPiso.Text) && !String.IsNullOrWhiteSpace(TProvincia.Text)
               && !String.IsNullOrWhiteSpace(TLocalidad.Text))
            {

                DialogResult result = MessageBox.Show("Estas a punto de modificar tu información", "Modificación de información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Perfil modificado", "Tarea completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bloqueado();
                }
                else
                {
                    MessageBox.Show("Modificacion cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campos vacios o espacios en blanco\r\nPor favor revisar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verifique sus datos antes de guardar porfavor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Desloqueado();

        }


    }
}
