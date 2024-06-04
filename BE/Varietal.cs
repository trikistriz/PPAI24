using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24.BE
{
    public class Varietal
    {
        private string _descripcion { get; set; }
        private int _porcentajeComposicion { get; set; }
        private TipoUva _tipoUva { get; set; }

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
        public Varietal()
        {
            _descripcion = obtenerNombreVarietal();
            _porcentajeComposicion = 0;
            _tipoUva = new TipoUva();

        }

        #region Getters and Setters

        public void SetDescripcion(string descripcion)
        {
            _descripcion = descripcion;
        }
        public string GetDescripcion()
        {
            return _descripcion;
        }
        public int GetPorcentajeComposicion()
        {
            return _porcentajeComposicion;
        }
        public void SetPorcentajeComposicion(int porcentaje)
        {
            _porcentajeComposicion = porcentaje;
        }
        public TipoUva GetTipoUva()
        {
            return _tipoUva;
        }
        public void SetTipoUva(TipoUva tipoUva)
        {
            _tipoUva = tipoUva;
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
