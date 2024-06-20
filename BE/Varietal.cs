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

        public Varietal()
        {
            _descripcion = "";
            _porcentajeComposicion = 0;
            _tipoUva = new TipoUva();

        }

        #region Getters and Setters

        public void SetNombre(string nombre)
        {
            _descripcion = nombre;
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
        
    }
}
