using System;


namespace Method
{
    class Calculator
    {
        public static int Plus(int a, int b) // a,b 매개변수
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        } 

        class MainApp
        {
            public static void Main()
            {
                int resuit = Calculator.Plus(3, 4); // 3,4 인수
                Console.WriteLine(resuit);

                resuit = Calculator.Minus(5, 2);
                Console.WriteLine(resuit);
            }
        }
    }
}
