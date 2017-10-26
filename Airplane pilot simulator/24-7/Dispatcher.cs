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
        public int Score { get; set; }
       public Dispatcher():this("Elva",150)
       {
          
       }

        public Dispatcher(string Name)
        {
            Random t = new Random();
            this.Name = Name;
            N = t.Next(-200, 200);
        }
        public Dispatcher(string Name, int N)
        {
            this.Name = Name;
            this.N = N;
        }

        public void Print(int speed, int height)
        {
            int recommended_height = 7 * speed - N;
            Console.WriteLine("Name: {0} / Recomend height: {1}",Name, recommended_height);
        }
    }
}
