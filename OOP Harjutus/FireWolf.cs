using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harjutus
{
    class FireWolf : Wolf
    {
        public FireWolf()
        {
            Hitpoint = 100;
            Damage = 100;
        }

        public int Bite(int hp)
        {
            var userHitpoint = base.Attack(hp);
            Console.WriteLine("FireWolf Attacked");
            return userHitpoint;
        }
    }
}
