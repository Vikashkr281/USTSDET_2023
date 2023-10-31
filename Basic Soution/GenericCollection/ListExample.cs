using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class ListExample<T> where T : Exception
    {
        T vall, vall2;

        public ListExample(T vall, T vall2)
        {
           Vall = vall;
            Vall2 = vall2;
        }

        public T Vall { get => vall; set => vall = value; }
        public T Vall2 { get => vall2; set => vall2 = value; }
    }
}
