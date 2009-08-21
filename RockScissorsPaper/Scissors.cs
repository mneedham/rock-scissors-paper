namespace RockScissorsPaper
{
    public class Scissors : IWeaponOfMassDestruction
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

        public string Battling(IWeaponOfMassDestruction weapon)
        {
            if (new WeaponComparison(this, weapon).AreDifferent())
            {
                return weapon.BeatsScissors() ? "loss" : "win";
            }
            return "draw";
        }
    }
}