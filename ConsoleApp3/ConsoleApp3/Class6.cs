using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{


    //override
    class Baseclass 
    {
        public virtual void  show()
        
        {
            Console.WriteLine("hi i am base class");
        }
    }

    class Derivedclass: Baseclass
    {
        public override void show()

        {
            Console.WriteLine("hi i am derived  class");
        }
    }

     class Class6
    {
        public static void Main6()
        {
            Baseclass obj = new Baseclass();
            obj.show();
            obj = new Derivedclass();
            obj.show();

            //Derivedclass obj = new Derivedclass();



        }


    }
}
