using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class BattleSystem
    {
        public static int Attack(dynamic attacker, dynamic target)
        {
            int damage = 0;
            if (target.Health < 0)
            {
                damage = 0;
                target.Health = 0;
            }
            else
            {
                damage = attacker.AttackPower - target.Defense;
                target.Health = target.Health - damage;
                if (target.Health < 0)
                {
                    target.Health = 0;
                }
            }
            Console.WriteLine(attacker.Name + " Hits " + target.Name + " With Damage Dealt : "
            + damage + " and Updated health of \n" + target.Name + " is : " + target.Health);
            return target.Health;
        }
        public static int StartBattle(Player attacker, Monster target)
        {
            Random rand = new Random();

            while (attacker.Health > 0 && target.Health > 0)
            {
                int turn = rand.Next(2);
                if (turn == 0)
                {
                    Console.WriteLine(attacker.Name + "Turn.");
                    Attack(attacker, target);
                }
                if (turn == 1)
                {
                    Console.WriteLine(target.Name + "Turn.");
                    Attack(target, attacker);
                }
            }
            if (attacker.Health == 0)
            {
                Console.WriteLine(attacker.Name + "Defeat");
                return target.Health;
            }
            else
            {
                Console.WriteLine(target.Name + "Defeat");
                return attacker.Health;
            }
           
        }
    }
}
