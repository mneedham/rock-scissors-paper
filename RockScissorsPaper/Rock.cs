namespace RockScissorsPaper
{
    public class Rock : WeaponBase
    {
        public Rock() : base(weapon => weapon.BeatsRock()) { }

        public override bool BeatsPaper()
        {
            return false;
        }

        public override bool BeatsRock()
        {
            return false;
        }

        public override bool BeatsScissors()
        {
            return true;
        }
    }
}