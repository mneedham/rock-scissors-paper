using System;

namespace RockScissorsPaper
{
    public abstract class WeaponBase : IWeapon
    {
        private readonly Func<IWeapon, bool> beatenBy;

        protected WeaponBase(Func<IWeapon, bool> beatenBy)
        {
            this.beatenBy = beatenBy;
        }

        public abstract bool BeatsPaper();
        public abstract bool BeatsScissors();
        public abstract bool BeatsRock();

        public string Battling(IWeapon weapon)
        {
            if (new WinnerDetermination(this, weapon).CanWeGetAWinner())
            {
                return beatenBy(weapon) ? "loss" : "win";
            }
            return "draw";
        }

        public bool Beats(IWeapon weapon)
        {
            return !beatenBy(weapon);
        }
    }
}