namespace RockScissorsPaper
{
    public class WeaponComparison
    {
        private readonly IWeapon weaponOne;
        private readonly IWeapon weaponTwo;

        public WeaponComparison(IWeapon weaponOne, IWeapon weaponTwo)
        {
            this.weaponOne = weaponOne;
            this.weaponTwo = weaponTwo;
        }

        public bool AreDifferent()
        {
            return weaponOne.GetType() != weaponTwo.GetType();
        }
    }
}