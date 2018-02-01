using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harjutus
{
    abstract class Creature
    {
        protected string Name;
        protected int Hitpoint;
        protected int Damage;
        protected int Defence;
        protected bool Ranged1;
        protected int Ranged2;

        //public int Smash(int hp)
        //{
        //    Console.WriteLine(Name + " bite you!");
        //    Console.WriteLine(Name + "did " + Damage + "Damage");
        //    var userHitpoints = hp - 15;
        //    Console.WriteLine("User has " + hp + "Hitpoints");
        //    return hp - 15;
        //}

        public abstract int SpecialAttack(int hp);
    }
}
