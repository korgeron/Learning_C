using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_C__console.app_.TextGame
{
   public class Warrior
    {
        private int health;
        public string name;
        
        /*MUST BE WITHIN CLASS REFERENCE IN ORDER TO BE USED*/
        public Warrior(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public int getHealth()
        {
            return this.health;

        }

        public void setHealth(int health)
        {
            this.health = health;
        }

      public void Death()
        {
            Console.WriteLine("YOU DIED!!\nYou must beat the goblin before you can continue...");
        }


    }    
}
