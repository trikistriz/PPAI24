using System.Collections.Generic;

namespace PPAI24.BE
{
    public class IteradorVinos : IIterador<Vino>
    {
        private List<Vino> _elementos;
        private List<Object> _filtros;
        private int _posicionActual = 0;

        //public IteradorVinos(List<Vino> elementos)
        //{
        //    _elementos = elementos;
        //}
        public IteradorVinos(List<Vino> elementos, List<Object> filtros)
        {
            _elementos = elementos;
            _filtros = filtros;
        }

        public Vino ElementoActual()
        {
            if (CumpleFiltro(_elementos[_posicionActual]))
            {
                return _elementos[_posicionActual];
            }
            return null;
        }

        public bool CumpleFiltro(Vino v)
        {
            DateTime fechaReseñaDesde = (DateTime)_filtros[0];
            DateTime fechaReseñaHasta = (DateTime)_filtros[1];
            bool tipoReseña = (bool)_filtros[2];

            return v.tenesReseñasDelTipoEnPeriodo(fechaReseñaDesde, fechaReseñaHasta, tipoReseña);
        }

        public bool HaTerminado()
        {
            return _posicionActual >= _elementos.Count;
        }

        public void Primero()
        {
            _posicionActual = 0;
        }

        public void Siguiente()
        {
            _posicionActual++;
        }
    }

}
