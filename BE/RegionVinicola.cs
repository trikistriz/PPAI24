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

        private List<String> _nombresDeRegion = new List<string>
        {
            "Valle de Maipo",
            "Mendoza",
            "Valle de Colchagua",
            "Maldonado",
            "Valle del Maipo",
            "Valle de Uco",
            "Puente Alto"
        };

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

        public string ObtenerNombrePais()
        {
            Provincia provincia = new Provincia();
            string pais = provincia.ObtenerNombrePais();
            return pais;
        }

        public string ObtenerNombreRegion()
        {
            Random random = new Random();
            string nb = _nombresDeRegion[random.Next(_nombresDeRegion.Count)];

            return nb;
        }
    }
}
