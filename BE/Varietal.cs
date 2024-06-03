using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class Varietal
    {
        private string Descripcion { get; set; }
        private int PorcentajeComposicion { get; set; }
        private TipoUva TipoUva { get; set; }

        private List<String> _nombresDeVarietal = new List<String>
        {
            "Cabernet Sauvignon, Carménère",
            "Cabernet Sauvignon, Malbec",
            "Malbec",
            "Carmenère, Cabernet Sauvignon, Merlot",
            "Petit Verdot",
            "Carmenère",
            "Cabernet Sauvignon"
        };

        #region Getters and Setters

        public void SetDescripcion(string descripcion)
        {
            Descripcion = descripcion;
        }
        public string GetDescripcion()
        {
            return Descripcion;
        }
        public int GetPorcentajeComposicion()
        {
            return PorcentajeComposicion;
        }
        public void SetPorcentajeComposicion(int porcentaje)
        {
            PorcentajeComposicion = porcentaje;
        }
        public TipoUva GetTipoUva()
        {
            return TipoUva;
        }
        public void SetTipoUva(TipoUva tipoUva)
        {
            TipoUva = tipoUva;
        }
        #endregion
        public string obtenerNombreVarietal()
        {
            Random random = new Random();
            string nb = _nombresDeVarietal[random.Next(_nombresDeVarietal.Count)];

            return nb;
        }
    }
}
