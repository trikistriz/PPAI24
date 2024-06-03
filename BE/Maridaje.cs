using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class Maridaje
    {
        private string Nombre { get; set; }
        private string Descripcion { get; set; }

        public Maridaje()
        {
            Nombre = "";
            Descripcion = "";
        }

        #region Getters and Setters
        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nom)
        {
            Nombre = nom;
        }

        public string GetDescripcion()
        {
            return Descripcion;
        }

        public void SetDescripcion(string desc)
        {
            Descripcion = desc;
        }
        #endregion

    }
}
