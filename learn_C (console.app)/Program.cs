using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_C__console.app_
{
    class Program
    {
        /*MY CALCULATOR METHOD FOR EACH MATH CALCULATION*/
        static int MathStuff(int num1 , int num2, string operate)
        {
            int answer = 0;
            if (operate == "+")
            {
                /*Console.WriteLine("adding is here");*/
                 answer = num1 + num2;

            } else if (operate == "-")
            {
                /*Console.WriteLine("subtracting is here");*/
                  answer = num1 - num2;

            } else if (operate == "*")
            {
                /*Console.WriteLine("subtracting is here");*/
                  answer = num1 * num2;

            } else if (operate == "/")
            {
                /*Console.WriteLine("subtracting is here");*/
                  answer = num1 / num2;

            } else
            {
                Console.WriteLine("Thats not an operator...");
                
            }

            return answer;
        }

       


        static void Main(string[] args)
        {

            /*PRACTICE WITH ARRAYS*/
            string[] names = new string[7];
            names[0] = "Karl";
            names[1] = "Stan";
            names[2] = "Vex";
            names[3] = "Justin";
            names[4] = "Sam";
            names[5] = "Hector";
            names[6] = "Luther";
            /*PRACTICE WITH FOR EACH*/
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("```````````````````````````````````````````````````````````````````````````````````````````````````");

            Console.WriteLine("The length of this array is " + names.Length);

            Console.WriteLine("```````````````````````````````````````````````````````````````````````````````````````````````````");
            /*PRACTICE CHANGING VALUES IN ARRAY*/
            names[6] = "Marty";
            /*PRACTICE WITH FOR LOOP*/
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("["+(i + 1)+"]" + " " + names[i]);

            }

            Console.WriteLine("```````````````````````````````````````````````````````````````````````````````````````````````````");
            /*SMALL PRACTICE WITH OOP*/
            Person bill = new Person("Bill");
            bill.getName();

            /*MAKING THE CALCULATOR APPLICATION*/

            /*TODO: 
             * Creating a simple calculator app 
             * User should be able to: 
             *  1. input 2 numbers
             *  2. choose which operator they want to use
             */
            Console.WriteLine("```````````````````````````````````````````````````````````````````````````````````````````````````");

            while (true)
            {
                Console.WriteLine("Would you like to calculate some numbers? [Y/N]");
                string answer1 = Console.ReadLine();
                if (answer1.ToLower() == "n")
                {
                    Console.Write("Terminating Application...");
                    break;
                }
                else if (answer1.ToLower() == "y")
                {
                    Console.WriteLine("\nGive me a numbers\n");
                    int answer2 = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("\nGive me a math operator\n");
                    string answer3 = Console.ReadLine();
                    Console.WriteLine("\nGive me another numbers\n");
                    int answer4 = Convert.ToInt32(Console.ReadLine());
                   /* Console.WriteLine(answer2);
                    Console.WriteLine(answer3);*/
                    /*Console.WriteLine(answer2);*/
                    Console.WriteLine("```````````````````````````````````````````````````````````````````````````````````````````````````");
                    Console.WriteLine("Answer: " + MathStuff(answer2, answer4, answer3));
                    Console.WriteLine("```````````````````````````````````````````````````````````````````````````````````````````````````");
                    

                }
                else
                {
                    Console.WriteLine("\nThat is not a correct choice...\n");

                }

            }


            Console.WriteLine("\n```````````````````````````````````````````````````````````````````````````````````````````````````\n");
            /*TEXT ADVENTURE GAME STARTS HERE*/

            TextGame.Warrior phil = new TextGame.Warrior("Phil");

            Console.WriteLine(phil.getName());
            phil.setHealth(100);
            Console.WriteLine(phil.getHealth());
            TextGame.Goblin gobby = new TextGame.Goblin();
            gobby.setHealth(50);

            Console.WriteLine(gobby.getName());
            Console.WriteLine(gobby.getHealth());
            string input1 = null;
            bool gobbyDied = false;
            Console.WriteLine("Name yourself warrior!");                          
            
            while(input1 == null)
            {
                input1 = Console.ReadLine();
                if (input1 == "")
                {
                    input1 = null;
                    Console.WriteLine("No...really...freaking name yourself already...");                   
                }
            }

            TextGame.Warrior player = new TextGame.Warrior(input1);
                
                Console.WriteLine("Player: " +  "\""+ player.getName() + "\"" +  " has entered the arena! \nToday " + player.getName() + " will be facing the \"MIGHTY\" " + gobby.getName() + "!\nWould you like to fight for your life? [Y/N]");
                string input2 = Console.ReadLine();
            if (input2.ToLower() == "y")
            {
                player.setHealth(100);
                gobby.setHealth(0);
            } else if (input2.ToLower() == "n")
            {
                player.setHealth(0);
                
                
            }
            else
            {
                Console.WriteLine("You really need to listen to directions " + player.getName() + " \nNOW DIE!!\n");
                player.setHealth(0);
                
            }


            if (player.getHealth() == 0)
            {
                player.Death();
            }

            if (gobby.getHealth() == 0)
            {
                gobby.Death();
                 gobbyDied = true;
            }

            if (gobbyDied == true)
            {
                Console.WriteLine("NEW CODE!!!");
            }




















            Console.ReadLine();
        }
    }
}
