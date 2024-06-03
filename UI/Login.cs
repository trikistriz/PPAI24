using PPAI24.BE;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;

namespace PPAI24
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //para poder desplazar desde panel superior
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
        private void pnlLoginMove_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //--------------------------------------------------------------------------------------------

        //para ingresar con enter
        private void txtClaveUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresarUsuario_Click(sender, e);
            }
        }
        //--------------------------------------------------------------------------------------------

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
                Default def = new Default(user);
                def.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos");
            }


            //DESCOMENTAR PARA USAR DB
            //if (txtNombreUsuario.Text.Equals("") || txtClaveUsuario.Text.Equals("")) 
            //{
            //    MessageBox.Show("Ingrese Usuario y contraseña");
            //}
            //else 
            //{
            //    string n_usuario = txtNombreUsuario.Text;
            //    string password = txtClaveUsuario.Text;
            //    bool resultado = false;

            //    try
            //    {
            //        resultado = ValidarUsuario(n_usuario, password);

            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Error al consultar usuario");
            //    }

            //    if (resultado == true) 
            //    {
            //        string premium = "N";
            //        Usuario user = new Usuario(n_usuario, password, premium);
            //        Default def = new Default(user);
            //        def.Show();
            //        this.Hide();
            //    }
            //    else 
            //    {
            //        MessageBox.Show("Usuario no existente");
            //    }

            //}

        }


        //DESCOMENTAR PARA USAR DB
        //private bool ValidarUsuario(string usuario, string password)
        //{
        //    string cadena_conexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //    SqlConnection cn = new SqlConnection(cadena_conexion);
        //    try
        //    {
        //        bool res = false;
        //        SqlCommand cmd = new SqlCommand();

        //        string consulta = "SELECT * FROM usuario WHERE nombre LIKE @usuario AND password LIKE @password";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@usuario",usuario);
        //        cmd.Parameters.AddWithValue("@password", password);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = consulta;

        //        cn.Open();
        //        cmd.Connection = cn;

        //        DataTable tabla = new DataTable();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(tabla);

        //        if (tabla.Rows.Count == 1)
        //        {
        //            res = true;
        //        }
        //        else
        //        {
        //            res = false;
        //        }

        //        return res;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }

            
        //}



    }
}
