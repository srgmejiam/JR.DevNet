using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        #region Eventos de los Controles
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MessageBox.Show("Exito");
            }
        }
        #endregion


        #region Metodos y Funciones
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text)||string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de usuario.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese la contraseña.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            if(!DAL.Usuarios.ValidarUserName(txtUsuario.Text))
            {
                MessageBox.Show("Las credenciales que ingresó no son válidas. El usuario será bloqueado, si execede el limite de intentos fallidos.", "Credenciales Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(DAL.Usuarios.UsuarioBloqueado(txtUsuario.Text))
            {
                MessageBox.Show("Las credenciales que ingresó no son válidas. El usuario será bloqueado, si execede el limite de intentos fallidos.", "Credenciales Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //mandar email de bloqueo
                return false;
            }
            if(!DAL.Usuarios.ValidarPassword(txtUsuario.Text, txtPassword.Text))
            {
                MessageBox.Show("Las credenciales que ingresó no son válidas. El usuario será bloqueado, si execede el limite de intentos fallidos.", "Credenciales Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DAL.Usuarios.IntentosFallidos(txtUsuario.Text);
                return false;
            }
            return true;
        }

        #endregion

       
    }
}
