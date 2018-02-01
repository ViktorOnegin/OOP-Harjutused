using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harjutus
{
    class Program
    {
        static void Main(string[] args)
        {
            var hp = 100;

            var enemyWolf = new Wolf();
            hp = enemyWolf.Attack(hp);
            hp = enemyWolf.SpecialAttack(hp);

            Console.WriteLine();

            var FireWolf = new FireWolf();
            hp = FireWolf.Attack(hp);

            var FireCat = new FireCat();
            hp = FireCat.Kill(hp);
            hp = FireCat.SpecialAttack(hp);
            
            var BadMonkey = new BadMonkey();
            hp = BadMonkey.Throw(hp);
            hp = BadMonkey.SpecialAttack(hp);

            Console.ReadLine();
        }
    }
}
