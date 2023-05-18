using System;
using System.Threading;

namespace EX03
{
    public class MyThread
    {
        public static void Thread1()
        {
            Console.WriteLine("task one");
        }
        public static void Thread2()
        {
            Console.WriteLine("task two");
        }
    }
        public class ThreadExample
        {
            public static void Main()
            {
                Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
                Thread t2 = new Thread(new ThreadStart(MyThread.Thread2));
                t1.Start();
                t2.Start();
            }

        }
}

