using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AdventureQuestRPG
{
    public class Adventure
    {
       
       public static  List<Monster> Monsters = new List<Monster>{
            new GiantSpiders() , new Goblin() , new Ghost() , new Dragon() , new Boss()
        };
       static  List<string> Location = new List<string>
        {
            "Shadowfen","Thornfield","Venomwood","Mistwood","Ebonvale","Silverpeak"
        };


        public static string ChooseMap(int map)
        {
           
            string choosedMap;
            string start;
            map = map - 1;
            ConsoleColor[] colors = new ConsoleColor[6]
            {
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.Cyan,
                ConsoleColor.Red,
                ConsoleColor.Magenta,
                ConsoleColor.Yellow
            };
            choosedMap = Location[map];
            Console.WriteLine($"Map {choosedMap} chosen. Do you want to start the game? (Yes/No)");
            start = Console.ReadLine().ToLower();
            while (start != "yes" && start != "no")
            {
                Console.WriteLine("Invalid option. Please choose (Yes/No).");
                start = Console.ReadLine().ToLower();
            }
            if (start == "yes")
            {
                Console.ForegroundColor = colors[map];
            }
            if (start == "no")
            {
                Console.WriteLine("Come back for new adventures!!");
                Environment.Exit(0);
            }
            return choosedMap;
        }


        private static Player ChoosePlayer()
        {
            Raghad raghad = new Raghad();
            Ibrahim ibrahim = new Ibrahim();
            Console.WriteLine($"1 - {ibrahim.Name}");
            Console.WriteLine($"2 - {raghad.Name}");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine("Invalid input, please choose the number of the selected player.");
                choice = int.Parse(Console.ReadLine());
            }
            if (choice == 1)
            {
                return ibrahim;
            }
            else
            {
                return raghad;
            }
        }


        public static void Game()
        {
            // Pick Random Monster
            Random rand = new Random();
            int monster = rand.Next(5);
            Monster randMonster = Monsters[monster];
            // Starting the Game
            Console.WriteLine("Start the game by hitting start.");
            // Select the Player
            Console.WriteLine("Choose the player:");
            Player player = ChoosePlayer();
            // Select the Map
            Console.WriteLine("Select the map:");
            for (int i = 0; i < Location.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {Location[i]}");
            }
            int map = int.Parse(Console.ReadLine());
            while (map < 1 || map > 6)
            {
                Console.WriteLine("Invalid input, please choose the number of the map.");
                map = int.Parse(Console.ReadLine());
            }
            string choosedMap = ChooseMap(map);
            // Starting the Match
            Console.WriteLine("Match Start!!");
            Console.WriteLine($"You are facing: {randMonster.Name} in {choosedMap}");
            // Game Logic
            GameLogic(player, randMonster);
        }


        private static void GameLogic(Player player, Monster monster)
        {
            Random rand = new Random();
            int result = BattleSystem.StartBattle(player, monster);
            int count = 0;
            int chance = 3;
            while (true)
            {
                // Check if player won the battle
                if (result == player.Health)
                {
                    // Check if the defeated monster is the Boss
                    if (monster is Boss)
                    {
                        Console.WriteLine("Congratulations! You have defeated the Boss and won the game!");
                        Console.WriteLine("Game End");
                        Environment.Exit(0);
                    }
                    Console.WriteLine($"{player.Name} Wins!!! Level Up!");
                    Console.WriteLine($"{player.Name}'s Health: {player.OriginalHealth}");
                    Console.WriteLine("-----------------------------------------");
                    // Level up
                    Console.WriteLine("Choose an attribute to increase:");
                    Console.WriteLine("1 - Health");
                    Console.WriteLine("2 - Attack Power");
                    Console.WriteLine("3 - Defense");
                    int choice = int.Parse(Console.ReadLine());
                    while (choice < 1 || choice > 3)
                    {
                        Console.WriteLine("Invalid choice. Please select a valid option:");
                        choice = int.Parse(Console.ReadLine());
                    }
                    switch (choice)
                    {
                        case 1:
                            player.OriginalHealth += 10;
                            Console.WriteLine($"{player.Name}'s Health increased to {player.OriginalHealth}");
                            break;
                        case 2:
                            player.AttackPower += 10;
                            Console.WriteLine($"{player.Name}'s Attack Power increased to {player.AttackPower}");
                            break;
                        case 3:
                            player.Defense += 10;
                            Console.WriteLine($"{player.Name}'s Defense increased to {player.Defense}");
                            break;
                    }
                    Console.WriteLine("Next Round? (Yes/No)");
                    string round = Console.ReadLine().ToLower();
                    if (round == "yes")
                    {
                        player.Health = player.OriginalHealth;
                        Monster randMonster = Monsters[rand.Next(Monsters.Count)];
                        Console.WriteLine("your health is " + player.Health);
                        Console.WriteLine("Select new map? (Yes/No)");
                        string select = Console.ReadLine().ToLower();
                        if (select == "yes")
                        {
                            for (int i = 0; i < Location.Count; i++)
                            {
                                Console.WriteLine($"{i + 1} : {Location[i]}");
                            }
                            int map = int.Parse(Console.ReadLine());
                            while (map < 1 || map > 6)
                            {
                                Console.WriteLine("Invalid input, please choose the number of the map.");
                                map = int.Parse(Console.ReadLine());
                            }
                            ChooseMap(map);
                            result = BattleSystem.StartBattle(player, randMonster);
                            monster = randMonster;
                        }
                        else if (select == "no")
                        {
                            result = BattleSystem.StartBattle(player, randMonster);
                            monster = randMonster;
                        }
                        while (select != "yes" && select != "no")
                        {
                            Console.WriteLine("You Shuold choose Yes or No.");
                            Console.WriteLine("Select new map? (Yes/No)");
                            select = Console.ReadLine().ToLower();
                        }
                    }
                    else if (round == "no")
                    {
                        Console.WriteLine("Come back for new adventures!!");
                        Environment.Exit(0);
                    }
                    Console.WriteLine("-----------------------------------------");
                }
               
                // Check if player lost the battle
                else if (player.Health == 0 && count<3 )
                {
                    Console.WriteLine($"You lose you have {chance} chance. Try again? (Yes/No)");
                    string again = Console.ReadLine().ToLower();
                    if (again == "yes")
                    {
                        chance -=1;
                        count++;
                        player.Health = player.OriginalHealth; 
                        result = BattleSystem.StartBattle(player,monster);
                    }
                    else if (again == "no")
                    {
                        Console.WriteLine($"{player.Name} Defeat");
                        Console.WriteLine("Game Over");
                        Environment.Exit(0);
                    }
                    Console.WriteLine("-----------------------------------------");
                }
                else
                {
                    Console.WriteLine("You lost your Chance.");
                    Console.WriteLine("Game Over!!");
                    Environment.Exit(0);
                }
            }
        }
    }
}
