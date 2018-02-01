using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harjutus
{
    class FireCat : Creature
    {
        public FireCat()
        {
            Name = "FireCat";
            Hitpoint = 30;
            Damage = 100;
            Defence = 5;
            Ranged1 = true;
            Ranged2 = 30;
        }

        public int Kill(int hp)
        {
            Console.WriteLine(Name + " Kill you!");
            Console.WriteLine(Name + " did " + Damage + " Damage " + "in ranged " + Ranged2);
            var userHitpoints = hp - 100;
            Console.WriteLine("User has " + hp + "Hitpoints");
            return hp - 100;
        }

        public override int SpecialAttack(int hp)
        {
            Console.WriteLine(Name + " !?!?!?!?!?!?!?!?!?! ");
            Console.WriteLine(Name + " did " + Damage + " Damage " + " in ranged " + Ranged2);
            var userHitpoints = hp - 3000;
            Console.WriteLine("User has " + hp + "Hitpoints");
            return userHitpoints;

        }
    }
}
