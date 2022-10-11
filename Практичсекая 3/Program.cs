using System.Runtime.ExceptionServices;

namespace Практичсекая_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            int Octave = 1;
            do
            {
                Console.WriteLine("Выберите дальнейшее действие: ");
                Console.WriteLine("Если вы хотите выйти из программы, нажмите F1");
                Console.WriteLine("Нажмите F3 для повышения октавы ");
                Console.WriteLine("Нажмите F7 для понижения октавы ");
                Console.WriteLine("Нынешняя октава: " + Octave);
                key = Console.ReadKey();
                int[] is_octave = Octaves(Octave);

                if (key.Key == ConsoleKey.Q)
                {
                    Zvook(is_octave[0]);
                }
                else if (key.Key == ConsoleKey.W)
                {
                    Zvook(is_octave[1]);
                }
                else if (key.Key == ConsoleKey.E)
                {
                    Zvook(is_octave[2]);
                }
                else if (key.Key == ConsoleKey.R)
                {
                    Zvook(is_octave[3]);
                }
                else if (key.Key == ConsoleKey.T)
                {
                    Zvook(is_octave[4]);
                }
                else if (key.Key == ConsoleKey.Y)
                {
                    Zvook(is_octave[5]);
                }
                else if (key.Key == ConsoleKey.U)
                {
                    Zvook(is_octave[6]);
                }
                else if (key.Key == ConsoleKey.I)
                {
                    Zvook(is_octave[7]);
                }
                else if (key.Key == ConsoleKey.O)
                {
                    Zvook(is_octave[8]);
                }
                else if (key.Key == ConsoleKey.P)
                {
                    Zvook(is_octave[9]);
                }
                else if (key.Key == ConsoleKey.G)
                {
                    Zvook(is_octave[10]);
                }
                else if (key.Key == ConsoleKey.H)
                {
                    Zvook(is_octave[11]);
                }



                if (key.Key == ConsoleKey.F3)
                {
                    Octave++;
                    if (Octave == 10)
                    {
                        Octave = 9;
                    }
                }
                if (key.Key == ConsoleKey.F7)
                {
                    Octave--;
                    if (Octave == 0)
                    {
                        Octave = 1;
                    }
                }
                Console.Clear();
            } while (key.Key != ConsoleKey.F1);
        }
        static int[] Octaves(int Octave = 1)
        {
            int[] Octave_1 = new int[12] { 16, 17, 18, 19, 20, 21, 23, 24, 25, 27, 29, 30 };
            int[] Octave_2 = new int[12] { 32, 34, 36, 38, 41, 43, 46, 49, 51, 55, 58, 61 };
            int[] Octave_3 = new int[12] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
            int[] Octave_4 = new int[12] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
            int[] Octave_5 = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 593 };
            int[] Octave_6 = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            int[] Octave_7 = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] Octave_8 = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            int[] Octave_9 = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
            switch (Octave)
            {
                case 1: return Octave_1;
                case 2: return Octave_2;
                case 3: return Octave_3;
                case 4: return Octave_4;
                case 5: return Octave_5;
                case 6: return Octave_6;
                case 7: return Octave_7;
                case 8: return Octave_8;
                case 9: return Octave_9;
                default: return Octave_1;

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