using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{



    public class PhotoBook
    {
        protected int  _Pages;


        //default constructor

        public PhotoBook()
            {
               _Pages = 16;
            }
        


         public PhotoBook(int pages)
        {
            _Pages = pages;
        }
        public void GetNumberPages()
        {
            Console.WriteLine("No. of pages are:" + _Pages);
        }

    }

    public class BigPhotoBook : PhotoBook
       {
           public BigPhotoBook(int pages)
           {
            _Pages = pages;
           }
           public void GetNumberPages()
           {
            Console.WriteLine("No. of pages are:" + _Pages);
           }

      }



     class PhotoBookTest
    {
        public static void Main() 
        {

            PhotoBook p = new PhotoBook();
            p.GetNumberPages();

            PhotoBook p1 = new PhotoBook(24);
            p1.GetNumberPages();

            PhotoBook p2 = new PhotoBook(64);
            p2.GetNumberPages();





        }

    }
}
