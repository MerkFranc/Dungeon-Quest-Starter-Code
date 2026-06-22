using System;
using FinalBattler.Character;
using FinalBattler.Character.Upgrades;
using FinalBattler.GamePlay;
using FinalBattler.Interfaces;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Final Battler!\n");

        Hero hero = new Hero
        {
            Name = "Arthas",
            CombatClass = CombatClass.Warrior,
            Level = 1,
            TotalHealth = 100,
            TotalPower = 20,
            TotalLuck = 5
        };
        hero.DisplayStats();

        Monster monster = new Monster
        {
            Name = "Goblin Grunt",
            MonsterType = MonsterType.Goblin,
            Level = 1,
            TotalHealth = 50,
            TotalPower = 10,
            TotalLuck = 2
        };
        Console.WriteLine($"Monster: {monster.Name}, Type: {monster.MonsterType}, Level: {monster.Level}, Health: {monster.TotalHealth}, Power: {monster.TotalPower}, Luck: {monster.TotalLuck}");

        Combat combat = new Combat();
        Console.WriteLine("\n--- Combat Begins ---");
        hero.BattleActions.Add(new Spell("Fireball", 5, 15));
        hero.Mana = 10; // Set hero's mana to ensure they can cast the spell
        combat.ExecuteAction(hero.BattleActions[0], hero, monster); // Hero uses Fireball on the monster
        Console.WriteLine($"Monster Health after Fireball: {monster.TotalHealth}");
        Console.WriteLine($"Hero Mana after Fireball: {hero.Mana}");
    }
}

