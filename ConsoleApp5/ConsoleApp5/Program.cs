using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 5;
                int b = 0;
               // int c = a / b;
                int[] ar = new int[5];
                ar[5] = 9;
               // Console.WriteLine(c);

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out---Some error occured");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine("Some error occured");
            }
            finally
            {
                Console.WriteLine("I am coming from finally");
            }
        }
    }
}
