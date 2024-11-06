using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24
{
    public interface IAgregado<T>
    {
        IIterador<T> CrearIterador();
    }

}
