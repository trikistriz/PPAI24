using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI24
{
    public class AgregadoConcreto<T> : IAgregado<T>
    {
        private readonly List<T> _items = new List<T>();

        public void AgregarItem(T item)
        {
            _items.Add(item);
        }

        public IIterador<T> CrearIterador()
        {
            return new IteradorConcreto<T>(_items);
        }
    }

}
