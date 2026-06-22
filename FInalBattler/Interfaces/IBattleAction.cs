using FinalBattler.Character;

namespace FinalBattler.Interfaces
{
    public interface IBattleAction
    {
        void Use(Hero hero, Monster monster);
    }
}