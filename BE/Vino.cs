using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class Vino
    {
		private string _nombre;
		private string _notaDeCataBodega;
		private float _precioARS;
		private string _aniada;

		public Vino(string nombre, string notaDeCataBodega, float precioARS, string aniada)
		{
			_nombre = nombre;
			_notaDeCataBodega = notaDeCataBodega;
			_precioARS = precioARS;
			_aniada = aniada;
		}

		public string aniada
		{
			get { return _aniada; }
			set { _aniada = value; }
		}

		public float precioARS
		{
			get { return _precioARS; }
			set { _precioARS = value; }
		}

		public string notaDeCataBodega
		{
			get { return _notaDeCataBodega; }
			set { _notaDeCataBodega = value; }
		}

		public string nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}


	}
}
