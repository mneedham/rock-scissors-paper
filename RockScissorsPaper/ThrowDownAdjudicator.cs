using System;

namespace RockScissorsPaper
{
    public class ThrowDownAdjudicator
    {
        private readonly IWeapon weaponOne;
        private readonly IWeapon weaponTwo;

        public ThrowDownAdjudicator(IWeapon weaponOne, IWeapon weaponTwo)
        {
            this.weaponOne = weaponOne;
            this.weaponTwo = weaponTwo;
        }

        public bool DoWeHaveAWinner()
        {
            return weaponOne.IsDifferentWeaponTo(weaponTwo);
        }

        public IWeapon Winner()
        {
            if (!DoWeHaveAWinner())
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