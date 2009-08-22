namespace RockScissorsPaper
{
    public class WinnerDetermination
    {
        private readonly IWeapon weaponOne;
        private readonly IWeapon weaponTwo;

        public WinnerDetermination(IWeapon weaponOne, IWeapon weaponTwo)
        {
            this.weaponOne = weaponOne;
            this.weaponTwo = weaponTwo;
        }

        public bool CanWeGetAWinner()
        {
            return weaponOne.GetType() != weaponTwo.GetType();
        }
    }
}