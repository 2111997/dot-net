
using ConsoleApp6.Models;
using System;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true) 
            {
                Console.WriteLine("Enter the choice");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.List Record");
                Console.WriteLine("3.Update Record");
                Console.WriteLine("4.Delete Record");
                Console.WriteLine("5.Exit");


                int ch = Convert.ToInt32(Console.ReadLine());
                SampleDBContext db = new SampleDBContext();
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter your name");
                        string name = Console.ReadLine();
                        Sample ss = new Sample();
                        ss.Fname = name;
                        db.Samples.Add(ss);
                        db.SaveChanges();
                        break;
                    case 2:
                        var data = db.Samples;

                        Console.WriteLine("record----");
                        foreach (var item in data)
                        {
                            Console.WriteLine(item.Fname + " | " + item.id);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Pleae enter id of your name which you want to update");
                        int InsertItem = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the new name");
                        var newName = Console.ReadLine();
                        var UpdatteObject = db.Samples.Where(x => x.id == InsertItem).FirstOrDefault();
                        UpdatteObject.Fname = newName;
                        db.Samples.Update(UpdatteObject);
                        db.SaveChanges();
                        break;
                    case 4:
                        Console.WriteLine("Pleae enter id of your name which you want to delete");
                        int DeleteItem = Convert.ToInt32(Console.ReadLine());
                        var DeleteObject = db.Samples.Where(x => x.id == DeleteItem).FirstOrDefault();
                        db.Samples.Remove(DeleteObject);
                        db.SaveChanges();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;

                }
           }

           

        }
    }
}
