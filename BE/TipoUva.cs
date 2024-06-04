using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class TipoUva
    {
        private string _nombre { get; set; }

        public TipoUva()
        {
            _nombre = "";
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
        #endregion
    }
}
