namespace RockScissorsPaper
{
    public class WeaponComparison
    {
        private readonly WeaponOfMassDestruction weaponOne;
        private readonly WeaponOfMassDestruction weaponTwo;

        public WeaponComparison(WeaponOfMassDestruction weaponOne, WeaponOfMassDestruction weaponTwo)
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