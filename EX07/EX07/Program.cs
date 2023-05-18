using System;
using System.Threading;

namespace EX07
{
    class Program
    {
        static bool stop = false;
        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(LowPriorityMethod));
            Thread t2 = new Thread(new ThreadStart(HighPriorityMethod));

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            Console.ReadLine();
            stop = true;
        }
        static void LowPriorityMethod()
        {
            while(!stop)
            {
                Console.WriteLine("Low priority method running!");
                Thread.Sleep(1000);
            }
        }
        static void HighPriorityMethod()
        {
            while(!stop)
            {
                Console.WriteLine("High priority method running!");
                Thread.Sleep(1000);
            }
        }
    }
}
