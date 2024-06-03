using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class Usuario
    {
		private string _constrasenia;
		private string _nombre;
		private string _premium;


		public Usuario(string n_usuario, string password, string premium)
		{
			_nombre = n_usuario;
			_constrasenia = password;
			_premium = premium;
		}

        #region Getters and Setters
        public string nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		public string contrasenia
		{
			get { return _constrasenia; }
			set { _constrasenia = value; }
		}
		public string premium
		{
			get { return _premium; }
			set { _premium = value; }
		}
		#endregion

	}
}
