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

        static void Start_Simulator()
        {
            Console.Write("Please, enter name ferst Dispatcher:");
            string ferst_d=Console.ReadLine();

            Console.Write("Please, enter name second Dispatcher:");
            string second_d = Console.ReadLine();
        }
        static void Menu(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    Start_Simulator();
                    break;              
                default:
                    Console.Clear();
                    Print_Start_Menu();
                    break;
            }
        }


        public static void Main()
        {

            Print_Start_Menu();
            ConsoleKey key;
            do
            {

                ConsoleKeyInfo info = Console.ReadKey();
                key = info.Key;
                Menu(key);

            } while (key!= ConsoleKey.Escape);
        }
    }
}
