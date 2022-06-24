using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_C__console.app_
{
    class Program
    {

       


        static void Main(string[] args)
        {
            string[] names = new string[7];
            names[0] = "Karl";
            names[1] = "Stan";
            names[2] = "Vex";
            names[3] = "Justin";
            names[4] = "Sam";
            names[5] = "Hector";
            names[6] = "Luther";

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("```````````````````````````````````````````````````````````````````````````````````````````````````");

            Console.WriteLine(names.Length);

            Console.WriteLine("```````````````````````````````````````````````````````````````````````````````````````````````````");
            
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("["+(i + 1)+"]" + " " + names[i]);

            }

            Console.WriteLine("```````````````````````````````````````````````````````````````````````````````````````````````````");

            Person bill = new Person("Bill");
            bill.getName();


            Console.ReadLine();
        }
    }
}
