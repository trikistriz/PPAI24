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
            _nombre = "";
            _regionVinicola = new RegionVinicola();
        }

        public String[] ObtenerRegionYPais()
        {
            String[] region = new String[2];
            region[0] = _regionVinicola.GetNombre();
            region[1] = _regionVinicola.ObtenerNombrePais(region[0]);

            return region;
        }

    }
}
