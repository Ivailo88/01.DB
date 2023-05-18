using System;
using System.Threading;

namespace Нестатичен_Метод
{
    public class MyThread
    {
        public static void Thread()
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
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread));
            t1.Start();
            t2.Start();
        }
    }
}