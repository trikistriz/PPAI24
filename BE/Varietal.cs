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

        #region Getters and Setters
        
        public void SetNombre(string nombre)
        {
            Descripcion = nombre;
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
    }
}
