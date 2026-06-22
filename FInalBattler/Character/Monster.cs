namespace FinalBattler.Character
{
    public class Monster : Creations
    {
        public MonsterType MonsterType { get; set; }

        public void TakeDamage(int amount)
        {
            TotalHealth -= amount;
        }

        public void Attack(Hero hero)
        {
            hero.TotalHealth -= TotalPower;
        }

    }
    public enum MonsterType
    {
        None,
        Goblin,
        Orc,
        Troll,
        Dragon
    }
}
