using System;
using System.Threading;

namespace Статичен_метод
{
    public class MyThread
    {
        public static void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class ThreadExample
    {
        public static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));
            t1.Start();
            t2.Start();
        }

    }
}
