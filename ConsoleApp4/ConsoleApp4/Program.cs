using System;

namespace ConsoleApp4
{


    //interface
    interface vehicle

    {
        void changegear(int a);
        void speedup(int a);
        void applybreaks(int a);
    }

    class Bicycle : vehicle
    {
        int speed;
        int gear;

        public void applybreaks(int decrement)
        {
            speed = speed - decrement;
        }
        public void changegear(int newgear)
        {
            gear = newgear;

        }
        public void speedup(int increment)
        {
            speed = speed + increment;
        }

        public void PrintStates()
        {
            Console.WriteLine("Bicycle Speed " + speed + " Bicycle Gear: " + gear);
        }

     }

    class Bike : vehicle
    {
        int speed;
        int gear;

        public void applybreaks(int decrement)
        {
            speed = speed - decrement;
        }
        public void changegear(int newgear)
        {
            gear = newgear;

        }
        public void speedup(int increment)
        {
            speed = speed + increment;
        }

        public void PrintStates()
        {
            Console.WriteLine("Bike Speed " + speed + " Bike Gear: " + gear);
        }

    }

 class Program
    {
        static void Main1(string[] args)
        {
            Bicycle b = new Bicycle();
            b.changegear(2);
            b.speedup(3);
            b.applybreaks(1);
            b.PrintStates();

            Bike b1 = new Bike();
            b1.changegear(2);
            b1.speedup(3);
            b1.applybreaks(1);
            b1.PrintStates();









           // Console.WriteLine("Hello World!");
        }
    }
}
