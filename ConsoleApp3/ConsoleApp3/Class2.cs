using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    public class Person
    {

        protected int age;

        public void Greet()
        {
            Console.WriteLine("hello");

        }

        public void SetAge(int _age)
        {
            age= _age;
        }
  
    }
    
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I am studying");
        }

        public void ShowAge()
        {

            Console.WriteLine("My Age is" +age );

        }
    }
    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I am explaining");
        }
    }






    class Class2
    {
        public static void Main2()
        {
            Person p = new Person();
            p.Greet();

            Student s = new Student();
            s.SetAge(20);
            s.Greet();
            s.ShowAge();
            s.Study();


            Teacher T = new Teacher();
            T.SetAge(50);
            T.Greet();

            T.Explain();



        }



    }
}
