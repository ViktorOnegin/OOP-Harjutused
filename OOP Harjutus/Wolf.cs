using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harjutus
{
    class Wolf : Creature
    {
        public Wolf()
        {
            Name = "Wolf";
            Hitpoint = 60;
            Damage = 25;
            Defence = 15;
            Ranged1 = false;
        }

        public int Attack(int hp)
        {
            Console.WriteLine(Name + " bite you!");
            Console.WriteLine(Name + "did " + Damage + "damage");
            var userHitpoints = hp - 15;
            Console.WriteLine("User has " + hp + "Hitpoints");
            return hp - 15;
        }

        public override int SpecialAttack(int hp)
        {
            Console.WriteLine(Name + " double bite you!");
            Console.WriteLine(Name + "did " + Damage + "Damage");
            var userHitpoints = hp - 15 - 10;
            Console.WriteLine("User has " + hp + "Hitpoints");
            return userHitpoints;
            
        }
    }
}
