namespace RockScissorsPaper
{
    public class BattleBase
    {
        protected BattleResult BattleBetween(IWeapon weaponOne, IWeapon weaponTwo)
        {
            return new Battle(weaponOne, weaponTwo).Commence();
        }
    }
}