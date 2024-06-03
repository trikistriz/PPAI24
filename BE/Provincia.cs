using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class Provincia
    {
        private string Nombre { get; set; }
        private List<RegionVinicola> Regiones { get; set; }

        public Provincia()
        {
            Nombre = "";
        }
        public Provincia(List<RegionVinicola> regiones)
        {
            Nombre = "";
            Regiones = regiones;
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
        public List<RegionVinicola> GetRegiones()
        {
            return Regiones;
        }
        public void SetRegiones(List<RegionVinicola> regiones)
        {
            Regiones = regiones;
        }
        #endregion

        public string ObtenerNombrePais()
        {
            Pais pais = new Pais();
            return pais.ObtenerNombrePais();
        }
    }
}
