using System;
using System.Threading;

namespace EX04
{
    class Program
    {
        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(Method1));
            Thread t2 = new Thread(new ThreadStart(Method2));

            t1.Start();
            t2.Start();
        }
        static void Method1()
        {
            while(true)
            {
                Console.WriteLine("Method1 Running");
            }
        }
        static void Method2()
        {
            while(true)
            {
                Console.WriteLine("Method2 Running");
            }
        }
    }
}
