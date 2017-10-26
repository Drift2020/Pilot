using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_7
{
    delegate void Dis(object aircraft,object disp);

    class Aircraft
    {
        public int Height { get; set; }
        public int Speed { get; set; }
       

        public Aircraft()
        {
            Height = 0;
            Speed = 0;
        }

       
        List<Dis> list = new List<Dis>();
        public event Dis Observation
        {
            // Используем аксессоры событий
            add
            {
                list.Add(value);
            }

            remove
            {
                list.Remove(value);
            }
        }

        public void Generator_Event_Observation(object disp)
        {           
            if (list.Count != 0)
                foreach (Dis i in list)
                {
                    i(this, disp);
                }
        }
    }
}
