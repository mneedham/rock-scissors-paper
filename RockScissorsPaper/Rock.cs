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

        public string Battling(WeaponOfMassDestruction weapon)
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