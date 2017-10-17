using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_7
{

    class Dispatcher
    {
        public string Name { get; set; }
        public int N { get; set; }

        Dispatcher():this("Elva",150)
        {

        }
        Dispatcher(string Name, int N)
        {
            this.Name = Name;
            this.N = N;
        }

    }
}
