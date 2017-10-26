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
        public bool Quest { get; set; }
        public bool Life_Air { get; set; }
        public bool Flight_start { get; set; }
      

        public Dispatcher():this("Elva",150)
       {
          
       }
        public Dispatcher(string Name)
        {
            Random t = new Random();
            this.Name = Name;
            Quest = false;
            Flight_start = false;
            N = t.Next(-200, 200);
        }
        public Dispatcher(string Name, int N)
        {
            this.Name = Name;
            this.N = N;
            Quest = false;
            Flight_start = false;
        }
     

        public void Flight_check(int speed, int height)
        {
            int recommended_height = 7 * speed - N;

            if (Flight_start)
            {
                Console.WriteLine("Name: {0} / Recomend height: {1}", Name, recommended_height);
            }
          
            if (   ((height- recommended_height > 300 && height - recommended_height>=0)    && (height - recommended_height <= 600 && height - recommended_height >= 0)) 
                && ((height - recommended_height > -300 && height - recommended_height < 0) && (height - recommended_height <= -600 && height - recommended_height < 0))
                && Flight_start)
            {
                Score += 25;
            }
            //else if((height - recommended_height > 600|| height - recommended_height > -600) && (height - recommended_height <= 1000|| height - recommended_height <= -1000) 
            //    && Flight_start )
            //{
            //    Score += 50;
            //}
            else if((height - recommended_height >1000) && Flight_start)
            {              
                throw new Exception("The plane crashed!");
            }

            if(Score>=1000 && Flight_start)
            {
                throw new Exception("You are not suitable for flights!");
            }
           
            if(speed>1000)
            {
                Score += 100;
                Console.WriteLine("Slow down the speed!");
            }
            if (speed==1000)
            {
                Quest = true;
               
            }
            if (!Flight_start&&speed>=50 && !Quest)
            {
                Flight_start = !Flight_start;
            }

            if (Quest&& Flight_start && speed <= 0 && height <= 0)
            {
                Flight_start = false;
                throw new Exception("Aircraft is planted!");
            }
            else if(Flight_start && (speed <= 0&&height<=0))
            {
                throw new Exception("The plane crashed!");
            }
            
        }
    }
}

