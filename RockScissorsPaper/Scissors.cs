namespace RockScissorsPaper
{
    public class Scissors : WeaponOfMassDestruction
    {
        public bool BeatsPaper()
        {
            return true;
        }

        public bool BeatsScissors()
        {
            return false;
        }

        public bool BeatsRock()
        {
            return false;
        }
    }
}