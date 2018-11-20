using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] pers = new Person[10];

       
            for(int i = 0; i < 5; i++){
                pers[i] = new Person();
                Console.WriteLine("Enter firstname: ");
                pers[i].Fnamn = Console.ReadLine();
                Console.WriteLine("Enter lastname: ");
                pers[i].Lnamn = Console.ReadLine();
                Console.WriteLine("Enter age: ");
                pers[i].Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter gender: ");
                pers[i].Gender = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("_______________________");
                /*
                Console.WriteLine(pers[i].Fnamn);
                Console.WriteLine(pers[i].Lnamn);
                Console.WriteLine(pers[i].Age);
                Console.WriteLine(pers[i].Gender);
                */
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(pers[i].Fnamn);
                Console.WriteLine(pers[i].Lnamn);
                Console.WriteLine(pers[i].Age);
                Console.WriteLine(pers[i].Gender);
            }
            



                /*
                int x = 0;
                int y = 0;
                double z = Math.PI;

                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x);
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(y);
                Console.WriteLine(z);

                */
                Console.ReadLine();
        }

    }
}
