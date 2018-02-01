using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harjutus
{
    class BadMonkey : Creature
    {
        public BadMonkey()
        {
            Name = "BadMonkey";
            Hitpoint = 60;
            Damage = 25;
            Defence = 15;
            Ranged1 = false;
        }

        public int Throw(int hp)
        {
            Console.WriteLine(Name + " is throwing a banana at you!");
            Console.WriteLine(Name + "did " + Damage + "Damage");
            var userHitpoints = hp - 15;
            Console.WriteLine(" User has " + hp + " Hitpoints ");
            return hp - 15;
        }

        public override int SpecialAttack(int hp)
        {
            Console.WriteLine(Name + " is throwing a bananas at you!");
            Console.WriteLine(Name + " did " + Damage + " Damage ");
            var userHitpoints = hp - 50;
            Console.WriteLine(" User has " + hp + " Hitpoints ");
            return userHitpoints;
        }
    }
}
