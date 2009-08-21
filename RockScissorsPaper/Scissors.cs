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

        public string Battling(WeaponOfMassDestruction weapon)
        {
            if (new WeaponComparison(this, weapon).AreDifferent())
            {
                return weapon.BeatsScissors() ? "loss" : "win";
            }
            return "draw";
        }
    }
}