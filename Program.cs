using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ORGMUSIC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tone
            //Tone A 220
            //Tone B 247
            //Tone C 262
            //Tone D 294
            //Tone E 330
            //Tone F 349
            //Tone G 392

            //Delay
            //1600
            //800
            //400
            //200
            while (true)
            {
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(220, 400);
                        break;
                    case ConsoleKey.B:
                        Console.Beep(247, 400);
                        break;
                    case ConsoleKey.C:
                        Console.Beep(262, 400);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(294, 400);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(330, 400);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(349, 400);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(392, 400);
                        break;
                    case ConsoleKey.Q:
                        return ;
                        break;
                }

            }
            



        }
    }
}
