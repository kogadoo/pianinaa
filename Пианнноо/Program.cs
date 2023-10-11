namespace Пианнноо
{
    internal class Program
    {
        static int[] pustooktave = new int[12];

        static int[] nyloktave = new int[12] { 16, 17, 18, 19, 20, 22, 23, 24, 26, 28, 29, 31 };

        static int[] firstloktave = new int[12] { 33, 35, 37, 39, 41, 44, 46, 49, 52, 55, 68, 62 };

        static int[] secondloktave = new int[12] { 65, 69, 73, 78, 82, 87, 93, 98, 103, 110, 116, 123 };

        static int[] thirdloktave = new int[12] { 130, 138, 146, 155, 164, 174, 185, 19, 207, 220, 223, 246 };

        static int[] fourloktave = new int[12] { 261, 277, 293, 311, 330, 350, 370, 392, 415, 440, 466, 493 };

        static int[] fiveoctave = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };

        static int[] sixoctave = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };

        static int[] sevenoktave = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };

        static int[] eightoktave = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6572, 6645, 7020, 7459, 7902 };
        static void Main(string[] args)
        {
            Console.WriteLine("F1-F9 переключение между октавами");
            Console.WriteLine("С A-G - белые клавиши\nС Q-U - чёрные клавиши");
            Console.WriteLine("Первая октава");
            pustooktave = nyloktave;
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.F1 || key.Key == ConsoleKey.F2 || key.Key == ConsoleKey.F3 || key.Key == ConsoleKey.F4 || key.Key == ConsoleKey.F5 || key.Key == ConsoleKey.F6 || key.Key == ConsoleKey.F7 || key.Key == ConsoleKey.F8 || key.Key == ConsoleKey.F9)
                {
                    Swap(key);
                }
                Vivod(key);
            }
            while (true);
        }
        static int[] Swap(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.F1)
            {
                Console.WriteLine("Первая октава");
                pustooktave = nyloktave;
            }
            else if (key.Key == ConsoleKey.F2)
            {
                Console.WriteLine("Вторая октава");
                pustooktave = firstloktave;
            }
            else if (key.Key == ConsoleKey.F3)
            {
                Console.WriteLine("Третья октава");
                pustooktave = secondloktave;
            }
            else if (key.Key == ConsoleKey.F4)
            {
                Console.WriteLine("Четвертая октава");
                pustooktave = thirdloktave;
            }
            else if (key.Key == ConsoleKey.F5)
            {
                Console.WriteLine("Пятая октава");
                pustooktave = fourloktave;
            }
            else if (key.Key == ConsoleKey.F6)
            {
                Console.WriteLine("Шестая октава");
                pustooktave = fiveoctave;
            }
            else if (key.Key == ConsoleKey.F7)
            {
                Console.WriteLine("Седьмая октава");
                pustooktave = sixoctave;
            }
            else if (key.Key == ConsoleKey.F8)
            {
                Console.WriteLine("Восьмая октава");
                pustooktave = sevenoktave;
            }
            else if (key.Key == ConsoleKey.F9)
            {
                Console.WriteLine("Девятая октава");
                pustooktave = eightoktave;
            }
            return pustooktave;
        }

        static void Vivod(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.Q:
                    Console.Beep(pustooktave[0], 300);
                    break;
                case ConsoleKey.W:
                    Console.Beep(pustooktave[2], 300);
                    break;
                case ConsoleKey.E:
                    Console.Beep(pustooktave[4], 300);
                    break;
                case ConsoleKey.R:
                    Console.Beep(pustooktave[5], 300);
                    break;
                case ConsoleKey.T:
                    Console.Beep(pustooktave[7], 300);
                    break;
                case ConsoleKey.Y:
                    Console.Beep(pustooktave[9],300);
                    break;
                case ConsoleKey.U:
                    Console.Beep(pustooktave[11],300);
                    break;
                case ConsoleKey.A:
                    Console.Beep(pustooktave[1], 300);
                    break;
                case ConsoleKey.S:
                    Console.Beep(pustooktave[3], 300);
                    break;
                case ConsoleKey.D:
                    Console.Beep(pustooktave[6], 300);
                    break;
                case ConsoleKey.F:
                    Console.Beep(pustooktave[8], 300);
                    break;
                case ConsoleKey.G:
                    Console.Beep(pustooktave[10],300);
                    break;
            }
        }
    }
}