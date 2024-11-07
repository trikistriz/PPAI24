using System.Collections.Generic;

namespace PPAI24.BE
{
    public class IteradorReseñas : IIterador<Reseña>
    {
        private List<Reseña> _elementos;
        private List<Object> _filtros;
        private int _posicionActual = 0;

        //public IteradorReseñas(List<Reseña> elementos)
        //{
        //    _elementos = elementos;
        //}
        public IteradorReseñas(List<Reseña> elementos, List<Object> filtros)
        {
            _elementos = elementos;
            _filtros = filtros;
        }

        public Reseña ElementoActual()
        {
            if (CumpleFiltro(_elementos[_posicionActual]))
            {
                return _elementos[_posicionActual];
            }
            return null;
        }

        public bool CumpleFiltro(Reseña r)
        {
            DateTime fechaReseñaDesde = (DateTime)_filtros[0];
            DateTime fechaReseñaHasta = (DateTime)_filtros[1];
            bool tipoReseña = (bool)_filtros[2]; 

            if (r.sosDePeriodo(fechaReseñaDesde, fechaReseñaHasta) && r.sosDeSommelier(tipoReseña))
            {
                return true;
            }
            return false;
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
