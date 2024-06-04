using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class Bodega
    {
        private string _nombre { get; set; }
        private RegionVinicola _regionVinicola { get; set; }

        //harcodeada cosmica
        private List<string> _nombresDeBodegas = new List<string>
        {
            "Viña Almaviva",
            "Bodega Catena Zapata",
            "Viña Cobos",
            "Viña Lapostolle",
            "Bodega Garzón",
            "Viña Ventisquero",
            "Terrazas de los Andes",
            "Casa Silva",
            "Zuccardi",
            "Viña Concha y Toro"
        };

        #region Getters and Setters

        //getters y setters
        public string GetNombre()
        {
            return _nombre;
        }
        public void SetNombre(string nombre)
        {
            _nombre = nombre;
        }
        public RegionVinicola GetRegionVinicola()
        {
            return _regionVinicola;
        }
        public void SetRegionVinicola(RegionVinicola region)
        {
            _regionVinicola = region;
        }
        #endregion 

        public Bodega()
        {
            _nombre = ObtenerNombreBodega();
            _regionVinicola = new RegionVinicola();
        }

        public String[] ObtenerRegionYPais()
        {
            String[] region = new String[2];
            region[0] = _regionVinicola.ObtenerNombreRegion();
            region[1] = _regionVinicola.ObtenerNombrePais();

            return region;
        }

        public string ObtenerNombreBodega()
        {
            Random random = new Random();
            string nb = _nombresDeBodegas[random.Next(_nombresDeBodegas.Count)];

            return nb;
        }
    }
}
