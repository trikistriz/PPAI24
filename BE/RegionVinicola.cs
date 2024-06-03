using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class RegionVinicola
    {
        private string Nombre { get; set; }
        public RegionVinicola()
        {
            Nombre = "";
        }

        #region Getters and Setters
        public string GetNombre()
        {
            return Nombre;
        }
        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }
        #endregion

        //traer info de la bd
        //public string GetPais()
        //{
        //    ProvinciaData pd = new ProvinciaData();
        //    Provincia p = pd.GetProvinciaByRegion(Nombre);
        //    return p.GetPais();
        //}


    }
}
