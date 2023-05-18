using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionEx01
{
    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Cat says: meow meow");
        }
    }
}
