namespace RockScissorsPaper
{
    public class Scissors : ThrowBase
    {
        public Scissors() : base(weapon => weapon.BeatsScissors()) { }

        public override bool BeatsPaper()
        {
            return true;
        }

        public override bool BeatsScissors()
        {
            return false;
        }

        public override bool BeatsRock()
        {
            return false;
        }
    }

 
}