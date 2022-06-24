using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_C__console.app_
{
   public class Person
    {
        private string name;


        private void SayHello(string name)
        {
            Console.WriteLine("Hi there! My name is " + name);
        }

        public Person(string name)
        {
            this.name = name;
        }



       
        public void getName()
        {
            Console.WriteLine(this.name);
        }










    }
}
