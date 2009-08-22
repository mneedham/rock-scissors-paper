namespace RockScissorsPaper
{
    public interface IThrow
    {
        bool BeatsPaper();
        bool BeatsScissors();
        bool BeatsRock();
        bool Beats(IThrow aThrow);
        bool IsDifferentThrowTo(IThrow aThrow);
    }
}