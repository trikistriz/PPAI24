using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class Pais
    {
        
        private string _nombre { get; set; }
        private List<Provincia> _provincias { get; set; }
        private List<String> _nombresDePaises = new List<String>
        {
            "Chile",
            "Argentina",
            "Uruguay"
        };
        public Pais()
        {
            _nombre = ObtenerNombrePais();
        }
        public Pais(List<Provincia> provincias)
        {
            _nombre = ObtenerNombrePais();
            _provincias = provincias;
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
        public List<Provincia> GetProvincias()
        {
            return _provincias;
        }
        public void SetProvincias(List<Provincia> provincias)
        {
            _provincias = provincias;
        }
        #endregion

        public string ObtenerNombrePais()
        {
            Random random = new Random();
            string nb = _nombresDePaises[random.Next(_nombresDePaises.Count)];

            return nb;
        }
    }
}
