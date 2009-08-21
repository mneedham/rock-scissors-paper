namespace RockScissorsPaper
{
    public class Paper : WeaponBase
    {
        public Paper() : base(weapon => weapon.BeatsPaper()) { }

        public override bool BeatsRock()
        {
            return true;
        }

        public override bool BeatsScissors()
        {
            return false;
        }

        public override bool BeatsPaper()
        {
            return false;
        }
    }
}