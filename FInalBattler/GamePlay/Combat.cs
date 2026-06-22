using FinalBattler.Interfaces;
using FinalBattler.Character;

namespace FinalBattler.GamePlay
{
    public class Combat
    {
        public void ExecuteAction(IBattleAction action, Hero hero, Monster monster)
        {
            action.Use(hero, monster);
        }
    }
}
