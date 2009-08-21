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
            throw new System.NotImplementedException();
        }

        public bool BeatsScissors()
        {
            return true;
        }
    }
}