using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class Characters
    {

        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
        public Characters(string name, int health, int attackPower, int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
        }
    }
    public class Player : Characters
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
        public Player(string name, int health, int attackPower, int defense) :
            base(name, health, attackPower, defense)
        {
            Name=name; Health = health; AttackPower = attackPower; Defense = defense;
        }

    }
    public class Monster: Characters
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
        public Monster(string name, int health, int attackPower, int defense) :
            base(name, health, attackPower, defense)
        {
            Name = name; Health = health; AttackPower = attackPower; Defense = defense;
        }
    }
}


