namespace RockScissorsPaper
{
    public class Rock : IWeaponOfMassDestruction
    {
        public bool BeatsPaper()
        {
            return false;
        }

        public bool BeatsRock()
        {
            return false;
        }

        public string Battling(IWeaponOfMassDestruction weapon)
        {
            if (new WeaponComparison(this, weapon).AreDifferent())
            {
                return weapon.BeatsRock() ? "loss" : "win";
            }
            return "draw";
        }

        public bool BeatsScissors()
        {
            return true;
        }
    }
}