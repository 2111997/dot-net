using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class PropertiesInClass
    {
        public PropertiesInClass(double r)
        {
            _radius = r;
        }

        private double _radius;
        private const double _pi = 3.14;

        public double radius
        {
            get
            {
                return _radius;
            }
        }

        public void PrintCircumference()
        {
            Console.WriteLine(2 * _pi * radius);
        }
    
        
    }






    class Class1
    {
        public static void Main1()

        {
            PropertiesInClass s = new PropertiesInClass(5);
            Console.WriteLine("Radius is " + s.radius);
            s.PrintCircumference();

        }
        
        
     }
}
