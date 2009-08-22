using System;

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
            return weaponOne.IsDifferentWeaponTo(weaponTwo);
        }

        public IWeapon Winner()
        {
            if (!CanWeGetAWinner())
            {
                throw new NoWinnerException();
            }
            return weaponOne.Beats(weaponTwo) ? weaponOne : weaponTwo;
        }
    }

    internal class NoWinnerException : Exception
    {
        public NoWinnerException() : base("We can't get a winner")
        {
        }
    }
}