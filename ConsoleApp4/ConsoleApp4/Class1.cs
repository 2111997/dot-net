using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehicle
    {
        //property
        public int Fuel 
        { 
            get;
            set;
        }
        //constructor

        public Car(int fuel)
        {
            Fuel = fuel;
        }

        //method
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Not fuel");
            }
        }

        public bool Refuel(int amount)
        {
            Fuel =Fuel + amount;
            return true;
        }
    }





    class Class1
        {
        public static void Main()
        {
                Car car = new Car(0);

                int fuel = Convert.ToInt32(Console.ReadLine());
                if (car.Refuel(fuel))
                {
                    car.Drive();
                }



            }
    }
}
