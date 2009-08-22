namespace RockScissorsPaper
{
    public class ThrowDownTestBase
    {
        protected ThrowDownResult ThrowDownBetween(IWeapon weaponOne, IWeapon weaponTwo)
        {
            return new ThrowDown(weaponOne, weaponTwo).Commence();
        }
    }
}