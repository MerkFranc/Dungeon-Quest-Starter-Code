using FinalBattler.Character.Upgrades;
using FinalBattler.Interfaces;

namespace FinalBattler.Character
{
    public class Hero : Creations, IHero
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Hero()
        {
            Name = "Unknown";
            Level = 0;
            Health = 1;
            Power = 1;
            Luck = 1;
            Mana = 1;
            TotalHealth = 1;
            TotalPower = 1;
            TotalLuck = 1;
            Items = new List<Item>();
            Skills = new List<Skill>();
            Spells = new List<Spell>();
            Equipment = new List<Equipment>();
        }

        public void DisplayStats(bool showTotalStats = false)
        {
            if (showTotalStats)
            {
                Console.WriteLine($"--- {Name} (Total Stats) ---");
                Console.WriteLine($"Level: {Level}");
                Console.WriteLine($"Health: {TotalPower}");
                Console.WriteLine($"Power: {TotalPower}");
                Console.WriteLine($"Luck: {TotalLuck}");
                Console.WriteLine($"Mana: {Mana}");
            }
            else
            {
                Console.WriteLine($"--- {Name} (Base Stats) ---");
                Console.WriteLine($"Level: {Level}");
                Console.WriteLine($"Health: {Health}");
                Console.WriteLine($"Power: {Power}");
                Console.WriteLine($"Luck: {Luck}");
                Console.WriteLine($"Mana: {Mana}");
            }
        }

        public void LevelUp()
        {
            Random random = new Random();
            Level++;

            switch (CombatClass)
            {
                case CombatClass.Warrior:
                    Health += random.Next(10, 21);
                    Power += random.Next(1, 4);
                    Luck += random.Next(1, 4);
                    break;
                
                case CombatClass.Wizard:
                    Health += random.Next(1, 16);
                    Power += random.Next(3, 6);
                    Luck += random.Next(1, 4);
                    break;
                
                case CombatClass.Rogue:
                    Health += random.Next(1, 16);
                    Power += random.Next(1, 4);
                    Luck += random.Next(3, 6);
                    break;
            }
        }

        public void CalculateTotals()
        {
            
        }
    }
}
