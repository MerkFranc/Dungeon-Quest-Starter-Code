using FinalBattler.Interfaces;

namespace FinalBattler.Character.Upgrades
{
    public class Spell : IBattleAction
    {
        public string SpellName { get; set; }
        public int ManaCost { get; set; }
        public int BaseDamage { get; set; }

        public Spell(string name, int manaCost, int baseDamage)
        {
            SpellName = name;
            ManaCost = manaCost;
            BaseDamage = baseDamage;
        }

        public int CalculateSpellDamage(int heroPower)
        {
            return BaseDamage + (heroPower / 2);
        }

        public void Use(Hero hero, Monster monster)
        {
            if (hero.Mana >= ManaCost)
            {
                hero.Mana -= ManaCost;
                monster.TotalHealth -= CalculateSpellDamage(hero.Power);
            }
        }
    }
}
