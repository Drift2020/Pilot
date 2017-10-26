using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _24_7
{
    class Start
    {
        enum Direction { UP, RIGHT, DOWN, LEFT, UP_SHIFT, RIGHT_SHIFT, DOWN_SHIFT, LEFT_SHIFT,NONE };

        static Aircraft Pilot = new Aircraft();

        private static void OnTimer(object sender, ElapsedEventArgs arg /* Предоставляет данные для события Elapsed */)
        {
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;

            ConsoleKey key;
            ConsoleKeyInfo cki = Console.ReadKey();
            
            key = cki.Key;

            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    if ((cki.Modifiers & ConsoleModifiers.Shift) != 0)
                        Pilot.Speed -= 150;
                    else
                        Pilot.Speed -= 50;
                    break;
                case ConsoleKey.RightArrow:
                    if ((cki.Modifiers & ConsoleModifiers.Shift) != 0)
                        Pilot.Speed += 150;
                    else
                        Pilot.Speed += 50;
                    break;
                case ConsoleKey.UpArrow:
                    if ((cki.Modifiers & ConsoleModifiers.Shift) != 0)
                        Pilot.Height += 500;
                    else
                        Pilot.Height += 250;
                    break;
                case ConsoleKey.DownArrow:
                    if ((cki.Modifiers & ConsoleModifiers.Shift) != 0)
                        Pilot.Height -= 500;
                    else
                        Pilot.Height -= 250;
                    break;


            }
            
          
            
        }

        static void Print_Start_Menu()
        {
            Console.WriteLine("1. Start simulator\nEsc. Exit");
        }
        static void Print_Work_Menu()
        {
            Console.WriteLine("1. Add disp\n2. Dell disp\nEsc. Exit");
        }
        static void Info_Air(int speed,int height)
        {
            Console.WriteLine("Speed: {0}\nHeight: {1}",speed,height);
        }      
        public static void Main()
        {
            int ball = 0;
            bool menu = true;
            List<Dispatcher> dispatchers = new List<Dispatcher>();
            Print_Start_Menu();
            ConsoleKey key;

            Timer t = new Timer();
            t.Interval = 1;
            // public event ElapsedEventHandler Elapsed - это событие происходит по истечении интервала времени
            t.Elapsed += new ElapsedEventHandler(OnTimer);

            
            do
            {
                ConsoleKeyInfo info = Console.ReadKey();
                key = info.Key;
                if (menu)
                {
                    switch (key)
                    {
                        case ConsoleKey.D1:

                            Console.Write("Please, enter name ferst Dispatcher:");
                            string ferst_d = Console.ReadLine();
                            dispatchers.Add(new Dispatcher(ferst_d));

                            Console.Write("Please, enter name second Dispatcher:");
                            string second_d = Console.ReadLine();
                            dispatchers.Add(new Dispatcher(second_d));

                            Pilot.Observation += (new Dis(Disp));

                            menu = !menu;

                            Console.Clear();
                            Print_Work_Menu();
                            t.Start(); // Начинает вызывать событие Elapsed
                            break;
                        default:
                            Console.Clear();
                            Print_Start_Menu();
                            break;
                    }
                }
                else
                {

                    switch (key)
                    {
                        case ConsoleKey.D1:
                            Console.Write("Please, enter name dispatcher:");
                            string name = Console.ReadLine();
                            dispatchers.Add(new Dispatcher(name));

                            break;
                        case ConsoleKey.D2:
                            if (dispatchers.Count > 2)
                            {
                                for (int i = 0; i < dispatchers.Count; i++)
                                {
                                    Console.WriteLine(i + ". " + dispatchers[i].Name);
                                }
                                Console.Write("Please, enter number dispatcher for dell:");

                                int number = Int32.Parse(Console.ReadLine());

                                if (number < dispatchers.Count)
                                {
                                    ball += dispatchers[number].Score;
                                    dispatchers.Remove(dispatchers[number]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Min 2 disp, please first add disp.");
                            }
                            break;
                      
                    }

                    Console.Clear();
                    Print_Work_Menu();
                    foreach (Dispatcher i in dispatchers)
                        Pilot.Generator_Event_Observation(i);
                    Info_Air(Pilot.Speed, Pilot.Height);
                }
            } while (key!= ConsoleKey.Escape);
        }

        private static void Disp(object air,object disp)
        {
            ((Dispatcher)disp).Print(((Aircraft)air).Speed, ((Aircraft)air).Height);
        }

    }
}
//Hp=7*Скорость (км/ч) – N,