using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Person1
    {
        public string Name 
        { 
            
          get;
          set;
        }

        public Person1(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }

        ~Person1()
        {
            Name = string.Empty;
        }
    }
    class Class8
    {
        public static void Main()
        {
            int total = 3;
            Person1[] persons = new Person1[total];

            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person1(Console.ReadLine());
            }

             for (int i = 0; i < total; i++)
             {
                Console.WriteLine(persons[i].ToString());
             }


        }
    }
}
