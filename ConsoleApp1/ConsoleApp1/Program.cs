using System;
using System.Linq;

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
            /*for (int i = 1; i <= 8; i++)
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
            }*/

            /*string input= "";
            Console.Write("Enter a string : ");
            input = Console.ReadLine();

            char[] temp = input.ToCharArray();
            Array.Reverse(temp);
            string output = new string(temp);
            
               
                if (input.Equals(output))
                {
                    Console.WriteLine("String is Palindrome");
                }
                else
                {
                    Console.WriteLine("String is not Palindrome Input");
                }
            Console.ReadLine();*/



            /* int max1, max2;
             int[] arr = { 20, 50, 45, 63, 23, 2 };
             Console.WriteLine("Array elements are:");

             for (int i = 0; i < arr.Length; i++)
             {
                 Console.WriteLine(arr[i] + "");

             }
             max1 = max2 = arr[0];
             for (int i = 0; i < arr.Length; i++)
             {

                 if (arr[i] > max1)
                 {
                     max2 = max1;
                     max1 = arr[i];
                 }
                 else if (arr[i] > max2)
                 {
                     max2 = arr[i];
                 }
              }
            // Console.WriteLine("first Max number   " + max1);
               Console.WriteLine("Second  Max number   " + max2);
               Console.ReadLine();*/

            /* int[] arr = { 1, 2, 3, 2, 4, 5, 2, 4 };

            if (arr.Length != arr.Distinct().Count())
            {
                Console.WriteLine("Array contains duplicates");
            }
            else
            {
                Console.WriteLine("Array does not contains duplicates");
            }*/

            /*int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            //int[,] arr3 = new int[2, 2];

            //Input from arr1
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("Please enter the value for arr1[" + row + "," + col + "]: ");
                    arr1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Input from arr2
            //for (int row = 0; row < 2; row++)
            //{
            //    for (int col = 0; col < 2; col++)
            //    {
            //        Console.WriteLine("Please enter the value for arr2[" + row + "," + col + "]: ");
            //        arr2[row, col] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            Console.WriteLine("Matrix before Transpose");
            //Matrix before Transpose
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    //Console.Write((arr1[row, col]+arr2[row,col])+"\t");
                    Console.Write(arr1[row, col] + "\t");
                }
                Console.WriteLine();
            }

            //process for transpose
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    arr2[col, row] = arr1[row, col];
                }
            }
            Console.WriteLine("Matrix After Transpose");
            //Output
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    //Console.Write((arr1[row, col]+arr2[row,col])+"\t");
                    Console.Write(arr2[row, col] + "\t");
                }
                Console.WriteLine();

            }*/


            /* int[] ar = new int[5] { 1, 2, 2, 3, 3 };
             int counter = 0;
             for (int i = 0; i < ar.Length; i++)
             {
                 counter = 0;

                 for (int j = 0; j < i - 1; j++)
                 {
                     if (ar[i] == ar[j])                      //Increment the counter when the search value is duplicate

                     {
                         counter++;
                     }
                 }

                 for (int k = i + 1; k < ar.Length; k++)
                 {
                     if (ar[i] == ar[k])
                     {
                         counter++;
                     }
                     if (ar[i] == ar[i + 1])
                     {
                         i++;
                     }
                 }
                 if (counter == 0)
                 {
                     Console.WriteLine(ar[i]);
                 }
             }*/


            int[][] jagged_array = new int[][]
                {
                   
                    new int[] { 1,2,2},
                    new int[] { 1,2,4,8,7},
                    new int[] { 1,2,5,9,8},
                    new int[] { 1,2,15,7,9},
                    new int[] { 1,2,5,6,3},
                 
                };

            for (int i = 0; i < jagged_array.Length; i++)
            {
                for (int j = 0; j < jagged_array[i].Length; j++)
                {
                    Console.Write(jagged_array[i][j]);
                }
                Console.WriteLine();
            }
































        }




        // Console.WriteLine("Hello World!");


    }
    }

