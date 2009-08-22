namespace RockScissorsPaper
{
    public interface IWeapon
    {
        bool BeatsPaper();
        bool BeatsScissors();
        bool BeatsRock();
        string Battling(IWeapon weapon);
        bool Beats(IWeapon weapon);
    }
}