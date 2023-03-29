using System;
namespace Jiiny_ex1
{
    class MainApp03
    {
        public static void Main()
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB); // 오버로드가 필요한 메소드

            Console.WriteLine("{0} + {1} = {2}", x, y, resultB);
        }

        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }

       
        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }
        
        
        // 더블형 매개변수 받을 수 있도록 오버로딩된 플러스 메소드 작성

    }
}
