using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int n=50;

            if (n < 18)
            {
                Console.WriteLine(n + "person is not eligible to voting");

            }
            else if (n >60 )
            {
                Console.WriteLine(n + "person is eligible to voting");
                Console.WriteLine(n + "senior citizen");

            }
            else 
            {
                Console.WriteLine(n + "person is eligible to voting");

                Console.WriteLine(n + "he is not seniour citizen");

            }*/


            /*Console.WriteLine("what is day today:");
            String day = Console.ReadLine();
            switch (day)
           {
            case "1":
                   Console.WriteLine("Monday");
                   break;
            
            
            case "2":
                   Console.WriteLine("Tuesday");
                   break;
            
            
            case "3":
                   Console.WriteLine("Wednesday");
                   break;
             
              
            case "4":
                   Console.WriteLine("Thursday");
                   break;
             
              
            case "5":
                   Console.WriteLine("friday");
                   break;
              
              
            case "6":
                   Console.WriteLine("Saturday");
                    break;
              
            default:
                   Console.WriteLine("days");
                   break;
            }*/
            /*Console.WriteLine("please enter the operator(+,-,*,/)");
            String op = Console.ReadLine();

            Console.WriteLine("please enter two values");

            String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine("numbers received from user :-     " + (Convert.ToInt32(s1) + Convert.ToInt32(s2)));
                    break;


                case "-":
                    Console.WriteLine("numbers received from user :-     " + (Convert.ToInt32(s1) - Convert.ToInt32(s2)));
                    break;

                case "*":
                    Console.WriteLine("numbers received from user :-     " + (Convert.ToInt32(s1) * Convert.ToInt32(s2)));
                    break;

                case "/":
                    Console.WriteLine("numbers received from user :-     " + (Convert.ToInt32(s1) / Convert.ToInt32(s2)));
                    break;

            }*/

            /*for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/
            //Console.Write();
            /*int n=8;
            for (int i = 1; i <= 8 ; i++)
            {
                for (int j = 1; j <= 8; j++)
                    if (i == 1 || i == 8 || i==j || j==1 || j==8 || j == (n-i+1))

                    {
                        Console.Write("*");
                    }
                    else {
                        Console.Write(" ");
                    }
               

                Console.WriteLine();
            }*/

            //int n = 8;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                    if (i == 1 || i == 8 || j == 1)

                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }


                Console.WriteLine();
            }

























        }




            // Console.WriteLine("Hello World!");


        }
    }

