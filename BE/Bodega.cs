using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class Bodega
    {
        private string Nombre { get; set; }
        private RegionVinicola RegionVinicola { get; set; }

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
            return Nombre;
        }
        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }
        public RegionVinicola GetRegionVinicola()
        {
            return RegionVinicola;
        }
        public void SetRegionVinicola(RegionVinicola region)
        {
            RegionVinicola = region;
        }
        #endregion 

        public Bodega()
        {
            Nombre = "";
            RegionVinicola = new RegionVinicola();

        }

        public String[] ObtenerRegionYPais()
        {
            String[] region = new String[2];
            region[0] = RegionVinicola.ObtenerNombreRegion();
            region[1] = RegionVinicola.ObtenerNombrePais();

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
