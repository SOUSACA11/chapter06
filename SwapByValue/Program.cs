using System;

namespace SwapByValue
{
    class Program
    {
        public static void Swap(int a, int b, int c)
        {
            int temp = b;
            b= a;
            a = c;
            c = temp;
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int z = 5;

            Console.WriteLine($"x:{x}, y:{y}, z:{z}");

            Swap(x, y,z);

            Console.WriteLine($"x:{x}, y:{y}, z:{z}");
        }
    }
}
