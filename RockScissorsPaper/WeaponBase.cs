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

        public bool Beats(IWeapon weapon)
        {
            return IsDifferentWeaponTo(weapon) && !beatenBy(weapon);
        }

        public bool IsDifferentWeaponTo(IWeapon weapon)
        {
            return GetType() != weapon.GetType();
        }
    }
}