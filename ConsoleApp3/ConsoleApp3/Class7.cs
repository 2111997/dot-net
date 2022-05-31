using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
     abstract class Animal
    {
        private string Name;

        public void SetName(string name) 
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }

        public abstract void eat();

    }
         class Dog : Animal
        {
             public override void eat()
             {

                Console.WriteLine("Eating");
             }
        }
    class Class7
    {
        public static void Main7()
        
        {
            Dog d = new Dog();
            //d.eat();
            Console.WriteLine("Enter Dog name");

            d.SetName(Console.ReadLine());
            Console.WriteLine(d.GetName());
            d.eat();

        }



    }
}
