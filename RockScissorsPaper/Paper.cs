namespace RockScissorsPaper
{
    public class Paper : IWeaponOfMassDestruction
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

        public string Battling(IWeaponOfMassDestruction weapon)
        {
            if (new WeaponComparison(this, weapon).AreDifferent())
            {
                return weapon.BeatsPaper() ? "loss" : "win";
            }
            return "draw";
        }
    }
}