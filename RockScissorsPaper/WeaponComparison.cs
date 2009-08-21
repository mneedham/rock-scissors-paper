namespace RockScissorsPaper
{
    public class WeaponComparison
    {
        private readonly IWeaponOfMassDestruction weaponOne;
        private readonly IWeaponOfMassDestruction weaponTwo;

        public WeaponComparison(IWeaponOfMassDestruction weaponOne, IWeaponOfMassDestruction weaponTwo)
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