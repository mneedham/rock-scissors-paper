namespace RockScissorsPaper
{
    public interface WeaponOfMassDestruction
    {
        bool BeatsPaper();
        bool BeatsScissors();
        bool BeatsRock();
        bool Beats(WeaponOfMassDestruction weaponOfMassDestruction);
    }
}