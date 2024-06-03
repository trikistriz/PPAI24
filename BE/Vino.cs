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
        private int _añada;
        private List<Reseña> _reseña { get; set; }

        //hardcodeada cosmica
        private List<String> _nombresDeVinos = new List<string>
        {
            "Almaviva",
            "Catena Zapata Nicolás Catena Zapata",
            "Viña Cobos Bramare Malbec Marchiori Vineyard",
            "Lapostolle Clos Apalta",
            "Bodega Garzón Single Vineyard Petit Verdot",
            "Viña Ventisquero Grey Carmenere",
            "Terrazas de los Andes Single Vineyard Las Compuertas Malbec",
            "Casa Silva Microterroir de los Lingues Carmenere",
            "Zuccardi Aluvional Paraje Altamira Malbec",
            "Concha y Toro Don Melchor"
        };

        #region Getters and Setters
        public int añada
        {
            get { return _añada; }
            set { _añada = value; }
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

        public Vino(string nombre, string notaDeCataBodega, float precioARS, int añada)
        {
            _nombre = nombre;
            _notaDeCataBodega = notaDeCataBodega;
            _precioARS = precioARS;
            _añada = añada;
        }
        public Vino() { }

        public float calcularPuntajeDeSommelierEnPeriodo(bool premium, DateTime fechaDesde, DateTime fechaHasta)
        {
            float suma = 0;
            int count = 0;

            foreach (Reseña reseña in _reseña)
            {
                if (reseña.sosDePeriodo(fechaDesde, fechaHasta) && reseña.sosDeSommelier() == premium)
                {
                    suma += reseña.GetPuntaje();
                    count++;
                }
            }

            if (count == 0)
                return 0;

            return calcularPuntajePromedio(suma, count);
        }
        public float calcularPuntajePromedio(float suma, int count)
        {
            return suma / count;
        }

        public string obtenerNombreVino() 
        {
            Random random = new Random();
            string nb = _nombresDeVinos[random.Next(_nombresDeVinos.Count)];

            return nb;
        }

        public float obtenerPrecio()
        {
            Random random = new Random();
            float precio = random.Next();
            return precio;
        }
        public String[] buscarInfoBodega()
        {
            String[] bodega = new string[3];
            String[] regionYPais = _bodega.ObtenerRegionYPais();
            bodega[0] = _bodega.ObtenerNombreBodega();
            bodega[1] = regionYPais[0];
            bodega[2] = regionYPais[1];

            return bodega;
        }

        public string obtenerNombreVarietal()
        {
            return _varietal.obtenerNombreVarietal();
        }
    }
}
