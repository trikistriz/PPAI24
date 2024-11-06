using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24
{
    public class IteradorConcreto<T> : IIterador<T>
    {
        private readonly List<T> _coleccion;
        private int _posicion = 0;

        public IteradorConcreto(List<T> coleccion)
        {
            _coleccion = coleccion;
            Primero();
        }

        public void Primero()
        {
            _posicion = 0;
        }

        public void Siguiente()
        {
            if (!HaTerminado())
            {
                _posicion++;
            }
        }

        //devuelve true si se alcanzaron todos los elementos
        public bool HaTerminado()
        {
            return _posicion >= _coleccion.Count;
        }

        public T ElementoActual()
        {
            if (!HaTerminado())
            {
                return _coleccion[_posicion];
            }
            else
            {
                throw new InvalidOperationException("No hay más elementos.");
            }
        }
    }

}
