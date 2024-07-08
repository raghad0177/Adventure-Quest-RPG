using System;
using System.Collections.Generic;
using System.Numerics;
namespace AdventureQuestRPG
{
    public class Inventory
    {
      
        public static int SwordCount { get; set; }
        public static int ArmorCount { get; set; }
        public  static int VitalityCount { get; set; }

        public static void AddRandomItem()
        {
            Random random = new Random();
            List<Items> items = new List<Items>
            {
                new Sword(),
                new Armor(),
                new Vitality()
            };
            int itemIndex = random.Next(items.Count);
            Items randomItem = items[itemIndex];
            Console.WriteLine($"{randomItem.Name} has been added. {randomItem.Description}");
            switch (randomItem)
            {
                case Sword _:
                    SwordCount++;
                    break;
                case Armor _:
                    ArmorCount++;
                    break;
                case Vitality _:
                    VitalityCount++;
                    break;
            }
        }


        public static int ViewItems() {
            Console.WriteLine("Inventory:");
            Console.WriteLine($"1. Swords: {SwordCount}");
            Console.WriteLine($"2. Armors: {ArmorCount}");
            Console.WriteLine($"3. Vitality Items: {VitalityCount}");
            Console.WriteLine($"4. Exit");
            Console.Write("Which item would you like to use? (1-4): ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
            return choice;
        }
       
    }
}