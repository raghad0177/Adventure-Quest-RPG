using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class Characters : IBattleStates
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }

    }
    public class Player : Characters
    {
        public int OriginalHealth { get; set; }
        public Player()
        {
        }

        public static (Player,int) UseItem(Player player, int choice)
        {
            int usedItem=0;

            switch (choice)
            {
                case 1:
                    if (Inventory.SwordCount == 0)
                    {
                        Console.WriteLine("You don't have any swords.");
                    }
                    else
                    {
                        player.AttackPower += 5;
                        Console.WriteLine($"Attack power increased to: {player.AttackPower}");
                        usedItem = Inventory.SwordCount--;
                    }
                    break;
                case 2:
                    if (Inventory.ArmorCount == 0)
                    {
                        Console.WriteLine("You don't have any armors.");
                    }
                    else
                    {
                        player.Defense += 5;
                        Console.WriteLine($"Defense increased to: {player.Defense}");
                        usedItem = Inventory.ArmorCount--;
                    }
                    break;
                case 3:
                    if (Inventory.VitalityCount == 0)
                    {
                        Console.WriteLine("You don't have any vitality items.");
                    }
                    else
                    {
                        player.OriginalHealth += 5;
                        Console.WriteLine($"Health increased to: {player.OriginalHealth}");
                        usedItem = Inventory.VitalityCount--;
                    }
                    break;
            }
            return (player,usedItem );
        }
    }

    public class Ibrahim : Player
    {

        
        public Ibrahim()
        {
            Name = "Ibrahim";
            Health = 100;
            AttackPower = 60;
            Defense = 40;
            OriginalHealth=Health;
        }

    }

    public class Raghad : Player
    {
        public Raghad()
        {
            Name = "Raghad";
            Health = 100;
            AttackPower = 50;
            Defense = 60;
            OriginalHealth=Health;
        }

    }

    public abstract class Monster : Characters
    {

    }

    public class GiantSpiders : Monster
    {
        public GiantSpiders()
        {
            Name = "GiantSpiders";
            Health = 30;
            AttackPower = 60;
            Defense = 40;
        }
    }

    public class Goblin : Monster
    {
        public Goblin()
        {
            Name = "Goblin";
            Health = 50;
            AttackPower = 60;
            Defense = 40;
        }
    }

    public class Ghost : Monster
    {
        public Ghost()
        {
            Name = "Ghost";
            Health = 100;
            AttackPower = 60;
            Defense = 30;
        }
    }

    public class Dragon : Monster
    {
        public Dragon()
        {
            Name = "Dragon";
            Health = 140;
            AttackPower = 50;
            Defense = 40;
        }
    }

    public class Boss : Monster
    {
        public Boss()
        {
            Name = "Lucifer";
            Health = 250;
            AttackPower = 180;
            Defense = 170;

        }
    }
}

