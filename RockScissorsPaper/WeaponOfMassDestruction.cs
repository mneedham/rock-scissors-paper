namespace RockScissorsPaper
{
    public interface WeaponOfMassDestruction
    {
        bool BeatsPaper();
        bool BeatsScissors();
        bool BeatsRock();
        string Battling(WeaponOfMassDestruction weapon);
    }
}