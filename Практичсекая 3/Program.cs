using System.Runtime.ExceptionServices;

namespace Практичсекая_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(" Если вы хотите начать игру, то нажмите Enter");
            Console.WriteLine(" Если хотиете завершить, нажмите Enter f1");
            ConsoleKeyInfo Key = Console.ReadKey();
            if (Key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Vubor_Octave();

            }
            else if (Key.Key == ConsoleKey.F1)
            {
                Console.Clear();
            }

        }
        static void Vubor_Octave() 
        {
            ConsoleKeyInfo key;
            int Octave = 1;
            do
            {
                Console.WriteLine("Если вы хотите изменить октаву, нажмите F3 или F7 для повышения или пониежния октавы");
                Console.WriteLine("Если захотите выйти, нажмите Escape");
                Console.WriteLine("Октава: " + Octave);
                key = Console.ReadKey();
                int[] octave = Octaves(Octave);

                if (key.Key == ConsoleKey.Q)
                {
                    Zvook(octave[0]);
                }
                else if (key.Key == ConsoleKey.W)
                {
                    Zvook(octave[1]);
                }
                else if (key.Key == ConsoleKey.E)
                {
                    Zvook(octave[2]);
                }
                else if (key.Key == ConsoleKey.R)
                {
                    Zvook(octave[3]);
                }
                else if (key.Key == ConsoleKey.T)
                {
                    Zvook(octave[4]);
                }
                else if (key.Key == ConsoleKey.Y)
                {
                    Zvook(octave[5]);
                }
                else if (key.Key == ConsoleKey.U)
                {
                    Zvook(octave[6]);
                }
                else if (key.Key == ConsoleKey.I)
                {
                    Zvook(octave[7]);
                }
                else if (key.Key == ConsoleKey.O)
                {
                    Zvook(octave[8]);
                }
                else if (key.Key == ConsoleKey.P)
                {
                    Zvook(octave[9]);
                }
                else if (key.Key == ConsoleKey.G)
                {
                    Zvook(octave[10]);
                }
                else if (key.Key == ConsoleKey.H)
                {
                    Zvook(octave[11]);
                }



                if (key.Key == ConsoleKey.F3)
                {
                    Octave++;
                    if (Octave == 5)
                    {
                        Octave = 4;
                    }
                }
                else if (key.Key == ConsoleKey.F7)
                {
                    Octave--;
                    if (Octave == 0)
                    {
                        Octave = 1;
                    }
                }
                Console.Clear();
            } while (key.Key != ConsoleKey.Escape);
        }
        static int[] Octaves(int Octave = 1)
        {
            int[] Octave_first = new int[12] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
            int[] Octave_second = new int[12] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
            int[] Octave_third = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 593 };
            int[] Octave_fourth = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };

            if (Octave == 1)
            {
                return Octave_first;
            }
            else if (Octave == 2)
            {
                return Octave_second;
            }
            else if (Octave == 3)
            {
                return Octave_third;
            }
            else if (Octave == 4)
            {
                return Octave_fourth;
            }
            else
            {
                return Octave_first;
            }
            
        }
        static void Zvook(int note)
        {
            if (note < 37)
            {
                note = 37;
            }
            Console.Beep(note, 250);
        } 
    }
}