using System;

namespace Lukin
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Численные методы одномерной оптимизации ");
            Console.WriteLine();
            Console.WriteLine("1. Метод Фибоначчи ");
            Console.WriteLine();
            Console.WriteLine("F(x) =(x+1)^3 + 5x^2 ");
            Console.WriteLine();
            double a = 1.1;
            double b = 1.3;
            double eps = 0.001;
            Fibonacci d = new Fibonacci();
            d.Fib(a,b,eps);

            Console.WriteLine();
            Console.WriteLine("2. Золотое сечение ");
            Console.WriteLine();
            Console.WriteLine("F(x) =(x+1)^3 + 5x^2");
            Console.WriteLine();
            Console.WriteLine("Отрезки [-2,2] и [-8,0]");
            Console.WriteLine();

            GoldSection gs = new GoldSection();
            Console.WriteLine("Значение минимума на отрезке [-2,2] - ");
            Console.WriteLine(gs.findMin(-2,2,0.001));
            Console.WriteLine("Значение максимума на отрезке [-8,0] - ");
            Console.WriteLine(gs.findMax(-8, 0, 0.001));
            Console.ReadKey();

        }
    }
}
