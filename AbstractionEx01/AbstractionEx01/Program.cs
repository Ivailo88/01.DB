using System;

namespace AbstractionEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.sleep();
            
                Cat myCat = new Cat();
                myCat.animalSound();
                myCat.sleep();
            
        }
        
    }
}
