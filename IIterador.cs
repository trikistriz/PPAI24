using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24
{
    public interface IIterador<T>
    {
        void Primero();
        void Siguiente();
        bool HaTerminado();
        T ElementoActual();
    }
}
