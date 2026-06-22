using FinalBattler.Interfaces;

namespace FinalBattler.Character.Upgrades
{
    public class Item: IBattleAction
    {
        public string ItemName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ItemPower { get; set; }

        public Item()
        {
        }

        public Item(string name, string description)
        {
            ItemName = name;
            Description = description;
        }

        public void Use(Hero hero, Monster monster)
        {
            hero.TotalHealth += ItemPower;
        }
    }
}
