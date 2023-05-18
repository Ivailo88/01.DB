using System;
using System.Threading;

namespace EX06
{
    class Program
    {
        static bool stop = false;
        static int count = 0;
        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(Method1));
            Thread t2 = new Thread(new ThreadStart(Method2));

            t1.Start();
            t2.Start();

            Console.ReadLine();
            stop = true;
        }
        static void Method1()
        {
            while (!stop)
            {
                Console.WriteLine("Method1 Running");
                Thread.Sleep(1000);
            }
        }
        static void Method2()
        {
            while (!stop)
            {
                while (count == 0)
                {
                    // busy waiting
                }
                Console.WriteLine("Method2 Running");
                count = 0;
            }
        }
    }
}