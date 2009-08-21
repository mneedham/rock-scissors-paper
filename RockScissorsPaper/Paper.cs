namespace RockScissorsPaper
{
    public class Paper : WeaponOfMassDestruction
    {
        public bool BeatsRock()
        {
            return true;
        }

        public bool BeatsScissors()
        {
            return false;
        }

        public bool BeatsPaper()
        {
            return false;
        }
    }
}