using System;

namespace ConsoleApp3
{

    class employee
    {
        private string Name;
        private int ID;
        private string Gender;
        private int Salary;





        public employee()
        {
            Name = "Sneha ";
        }

        //~ <class-name>()
        //get Input from User
        ~employee()
        {

        }



        public void GetData()
        {
        Console.WriteLine("employee Details are:");

         Console.WriteLine("Enter Employee Name:");
         Name = Console.ReadLine();

         Console.WriteLine("Enter Employee ID:");
          ID = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter Employee Gender:");
         Gender = Console.ReadLine();

        Console.WriteLine("Enter Employee Salary:");
        Salary = Convert.ToInt32(Console.ReadLine());
        
        }


        public void PrintData()
        {
            Console.WriteLine("employee Details are:");
            Console.WriteLine(Name);
            Console.WriteLine(ID);
            Console.WriteLine(Gender);
            Console.WriteLine(Salary);



        }


    }
    class Program
    {


       
        static void Main12(string[] args)

        {
            //employee a = new employee();
            //a.Name = "Sneha";
            //a.ID = 123;
            //a.Gender = "F";
            //a.Salary = 200000



            //employee a = new employee();
            //a.GetData();
            //a.PrintData();

            employee[] list = new employee[3];
            for (int i = 0; i < list.Length; i++)
            {
                employee s = new employee();
                s.GetData();
                list[i] = s;
            }

            for (int i = 0; i < list.Length; i++)
            {
                list[i].PrintData();
            }





            //Console.WriteLine("Hello World!");
        }
    }
}
