namespace RockScissorsPaper
{
    public interface IWeaponOfMassDestruction
    {
        bool BeatsPaper();
        bool BeatsScissors();
        bool BeatsRock();
        string Battling(IWeaponOfMassDestruction weapon);
    }
}