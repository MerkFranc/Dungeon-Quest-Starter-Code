using FinalBattler.Character.Upgrades;
using FinalBattler.Interfaces;

namespace FinalBattler.Character
{
    public class Hero : Creations, IHero
    {
        private int _health;
        public int Health
        {
            get => _health;
            set => _health = value < 0 ? 0 : value;
        }
        private int _power;
        public int Power
        {
            get => _power;
            set => _power = value < 0 ? 0 : value;
        }
        private int _luck;
        public int Luck
        {
            get => _luck;
            set => _luck = value < 0 ? 0 : value;
        }
        private int _mana;
        public int Mana
        {
            get => _mana;
            set => _mana = value < 0 ? 0 : value;
        }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<IBattleAction> BattleActions { get; set; }
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
            BattleActions = new List<IBattleAction>();
            Equipment = new List<Equipment>();
        }

        public void DisplayStats(bool showTotalStats = false)
        {
            if (showTotalStats)
            {
                Console.WriteLine($"--- {Name} (Total Stats) ---");
                Console.WriteLine($"Level: {Level}");
                Console.WriteLine($"Health: {TotalHealth}");
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
            TotalHealth = Health;
            TotalPower = Power;
            TotalLuck = Luck;
            
            foreach (var equipment in Equipment)
            {
                switch (equipment.StatBoostType)
                {
                    case StatBoostType.Health:
                        TotalHealth += equipment.BoostValue;
                        break;
                    case StatBoostType.Power:
                        TotalPower += equipment.BoostValue;
                        break;
                    case StatBoostType.Luck:
                        TotalLuck += equipment.BoostValue;
                        break;
                }
            }
        }
    }

    public enum CombatClass
    {
        None,
        Warrior,
        Wizard,
        Rogue
    }
}
