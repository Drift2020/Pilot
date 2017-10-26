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

        public void Flight_check(int speed, int height)
        {
            int recommended_height = 7 * speed - N;
          
            if()
        }
    }
}
//• Если разница в диапазоне от 300 до 600 то пилот получает
//25 штрафных очков, если от 600 до 1000 — то 50 очков.
//• Если разница превышает 1000, то объект-диспетчер
//генерирует исключительную ситуацию «Самолет
//разбился
//», которая должна быть обработана приложением,
//как прекращение тренировочного полета
//с соответствующей
//информацией на экране.
//• Если пилот, не завершив полет, набирает 1000 штрафных
//очков от любого диспетчера — то этот объект диспетчер
//генерирует исключительную ситуацию «Непригоден
//к полетам», которая также обрабатывается приложением.
//• Так же недопустимо, чтобы самолет в любой момент
//времени имел нулевую высоту и нулевую скорость
//(если это случилось — исключение «Самолет разбился»
//генерирует диспетчер). Кроме момента начала взлета
//и посадки(высота и скорость равны нулю)
//• При попытке превысить максимальную скорость
//диспетчер штрафует пилота на 100 очков и требует
//немедленно снизить скорость.
