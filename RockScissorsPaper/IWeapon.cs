namespace RockScissorsPaper
{
    public interface IWeapon
    {
        bool BeatsPaper();
        bool BeatsScissors();
        bool BeatsRock();
        bool Beats(IWeapon weapon);
    }
}