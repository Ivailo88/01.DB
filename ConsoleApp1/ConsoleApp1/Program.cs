using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine(add(3, 4));

            Func<int, int> factorial = n =>
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            };
            Console.WriteLine(factorial(5));

        }
    }
}
