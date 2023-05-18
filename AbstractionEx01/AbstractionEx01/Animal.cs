using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionEx01
{
    abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("ZzZ");
        }
    }
}
