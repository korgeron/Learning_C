using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_C__console.app_.TextGame
{
/*IF YOU USED : (OTHER CLASS NAME) IT WOULD MAKE THIS CLASS INHERIT THE OTHER CLASS. NEED TO USE OVERRIDE KEYWORD ON METHODS FOR OVERRIDE*/
    class Goblin
    {
        public int health;
        public string name = "Goblin";

        public int getHealth()
        {
            return this.health;

        }

        public string getName()
        {
            return this.name;
        }

        public void setHealth(int health)
        {
            this.health = health;
        }

        public void Death()
        {
            Console.WriteLine("YOU KILLED THE \"MIGHTY \"" + this.name + "!");
        }



    }
}
