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
        private string _nombre { get; set; }
        private List<RegionVinicola> _regiones { get; set; }

        public Provincia()
        {
            _nombre = "";
        }
        public Provincia(List<RegionVinicola> regiones)
        {
            _nombre = "";
            _regiones = regiones;
        }

        #region Getters and Setters
        public string GetNombre()
        {
            return _nombre;
        }
        public void SetNombre(string nombre)
        {
            _nombre = nombre;
        }
        public List<RegionVinicola> GetRegiones()
        {
            return _regiones;
        }
        public void SetRegiones(List<RegionVinicola> regiones)
        {
            _regiones = regiones;
        }
        #endregion

        public string ObtenerNombrePais()
        {
            Pais pais = new Pais();
            return pais.ObtenerNombrePais();
        }
    }
}
