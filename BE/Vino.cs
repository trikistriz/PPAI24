using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class Vino
    {
		private int id { get; set; }
		private Bodega _bodega { get; set; }
		private Varietal _varietal { get; set; }
		private string _nombre;
		private string _notaDeCataBodega;
		private float _precioARS;
		private int _aniada;
		private List<Reseña> _reseña {  get; set; }
		private List<Maridaje> _maridaje { get; set; }

		public Vino(string nombre, string notaDeCataBodega, float precioARS, int aniada)
		{
			_nombre = nombre;
			_notaDeCataBodega = notaDeCataBodega;
			_precioARS = precioARS;
			_aniada = aniada;
		}

        #region Getters and Setters
        public int aniada
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
        #endregion

    }
}
