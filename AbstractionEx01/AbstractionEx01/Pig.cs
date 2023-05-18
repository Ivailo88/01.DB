using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionEx01
{
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Pig says: wee wee");
        }
    }
}
