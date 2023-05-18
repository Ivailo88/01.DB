using System;

namespace CsharpDestructor{
    class Person { 
    
        public Person() {
            Console.WriteLine("Constructor Called."); 
        }
        //destructor
        ~Person() {
            Console.WriteLine("Destructor called.");
        }
        public static void Main(string [] args) {
            //creates object of person
            Person p1 = new Person();
        }
    }
}
