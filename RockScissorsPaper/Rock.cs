namespace RockScissorsPaper
{
    public class Rock : WeaponOfMassDestruction
    {
        public bool BeatsPaper()
        {
            return false;
        }

        public bool BeatsRock()
        {
            return false;
        }

        public bool Beats(WeaponOfMassDestruction weaponOfMassDestruction)
        {
            return !weaponOfMassDestruction.BeatsRock();
        }

        public bool BeatsScissors()
        {
            return true;
        }
    }
}