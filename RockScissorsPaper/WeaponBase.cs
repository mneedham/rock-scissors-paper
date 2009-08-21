using System;

namespace RockScissorsPaper
{
    public abstract class WeaponBase : IWeaponOfMassDestruction
    {
        private readonly Func<IWeaponOfMassDestruction, bool> beatenBy;

        protected WeaponBase(Func<IWeaponOfMassDestruction, bool> beatenBy)
        {
            this.beatenBy = beatenBy;
        }

        public abstract bool BeatsPaper();
        public abstract bool BeatsScissors();
        public abstract bool BeatsRock();

        public string Battling(IWeaponOfMassDestruction weapon)
        {
            if (new WeaponComparison(this, weapon).AreDifferent())
            {
                return beatenBy(weapon) ? "loss" : "win";
            }
            return "draw";
        }
    }
}