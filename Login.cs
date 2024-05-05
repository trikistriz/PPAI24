using PPAI24.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI24
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string Encrypt(string texto)
        {
            byte[] dataEncrypt = ProtectedData.Protect(Encoding.UTF8.GetBytes(texto), null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(dataEncrypt);
        }
        public static string Decrypt(string textoEncriptado)
        {
            byte[] dataEncrypt = Convert.FromBase64String(textoEncriptado);
            byte[] dataDescrypt = ProtectedData.Unprotect(dataEncrypt, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(dataDescrypt);
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnIngresarUsuario_Click(object sender, EventArgs e)
        {
            string usuarioValido = "admin";
            string passwordValido = "admin";

            string n_usuario = txtNombreUsuario.Text;
            string password = txtClaveUsuario.Text;

            if (usuarioValido == n_usuario && passwordValido == password)
            {
                string premium = "N";
                Usuario user = new Usuario(n_usuario, password, premium);
                Default def = new Default();
                def.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos");
            }


        }

        private void txtClaveUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresarUsuario_Click(sender, e);
            }
        }

        private void pnlLoginMove_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
