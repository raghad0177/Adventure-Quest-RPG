using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AdventureQuestRPG
{
    public abstract class Items
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class Sword : Items
    {
        public Sword()
        {
            Name = "Shadowfang Blade";
            Description = "Increase the AttackPower by 5";
        }
    }
    public class Armor : Items
    {
        public Armor()
        {
            Name = "Shield";
            Description = "Increase the Defense by 5";
        }
    }
    public class Vitality : Items
    {
        public Vitality()
        {
            Name = "Vitality";
            Description = "Increase the Health by 5";
        }
    }
}







