using System;
using System.Collections;
using System.Text;

namespace ConsoleApp4
{
    class Class3
    {
        public static void Main() 
        {

          
            Console.WriteLine("----------");

            Stack stk = new Stack();

            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sql server");
            stk.Pop();


            foreach (var item in stk)
            {

                Console.WriteLine(item);
            }


            Console.WriteLine("================");
            //queue
            //FIFO
            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sql server");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

        }



    }
}
