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
            int damage;
            if (target.Health <= 0)
            {
                damage = 0;
                target.Health = 0;
            }
            else
            {
                damage = Math.Max(5, attacker.AttackPower - target.Defense);
                target.Health = target.Health - damage;
                if (target.Health < 0)
                {
                    target.Health = 0;
                }
            }
            Console.WriteLine(attacker.Name + " Hits " + target.Name + " With Damage Dealt: "
                              + damage + " and Updated health of \n" + target.Name + " is: " + target.Health);
            return target.Health;
        }
        public static int StartBattle(Player attacker, Monster target)
        {
            Random rand = new Random();
            int view=0;
            // Allow the player to use items before the battle starts
            Console.WriteLine("Do you want to use or check any item before the battle starts? (Yes/No)");
            string choice1 = Console.ReadLine().ToLower();
            if (choice1 == "yes")
            {
                view = Inventory.ViewItems();
                Player.UseItem(attacker, view);
            }
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
                Console.WriteLine(target.Name + " Defeat");
                Random random = new Random();
                int chance = random.Next(100);
                if (chance <= 90)
                {
                    Inventory.AddRandomItem();
                    Console.WriteLine("You received a random item!");
                }
                Console.WriteLine("Do you want to see your Items? (Yes/No)");
                string choice2 = Console.ReadLine().ToLower();
                if (choice2 == "yes")
                {
                    view = Inventory.ViewItems();
                    Player.UseItem(attacker,view);
                }
            }
            return attacker.Health;
        }
    }
}