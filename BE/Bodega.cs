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

        public String[] getRegionYPais()
        {
            String[] region = new String[5];
            region[0] = RegionVinicola.GetNombre();
            region[1] = RegionVinicola.GetPais();

            return region;
        }

       
    }
}
