namespace RockScissorsPaper
{
    public class Paper : WeaponOfMassDestruction
    {
        public bool BeatsRock()
        {
            return true;
        }

        public bool Equals(Paper obj)
        {
            return !ReferenceEquals(null, obj);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (Paper)) return false;
            if (obj.GetType() == GetType()) return true;
            return Equals((Paper) obj);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public bool BeatsScissors()
        {
            return false;
        }

        public bool BeatsPaper()
        {
            return false;
        }

        public string Battling(WeaponOfMassDestruction weapon)
        {
            return Equals(weapon) ? "draw" : "win";
        }
    }
}