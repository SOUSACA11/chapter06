﻿using System;
namespace Jiiny_ex1
{
    class MainApp01
    {
        static double Square(double arg)
        {
            double star = arg * arg;
            return star;
        }

        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

           // Console.WriteLine("결과 : {0}", Square(arg));
            Console.WriteLine($"결과 : {Square(arg)}");
        }
    }
}
