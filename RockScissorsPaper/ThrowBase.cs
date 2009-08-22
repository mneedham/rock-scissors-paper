using System;

namespace RockScissorsPaper
{
    public abstract class ThrowBase : IThrow
    {
        private readonly Func<IThrow, bool> beatenBy;

        protected ThrowBase(Func<IThrow, bool> beatenBy)
        {
            this.beatenBy = beatenBy;
        }

        public abstract bool BeatsPaper();
        public abstract bool BeatsScissors();
        public abstract bool BeatsRock();

        public bool Beats(IThrow aThrow)
        {
            return IsDifferentThrowTo(aThrow) && !beatenBy(aThrow);
        }

        public bool IsDifferentThrowTo(IThrow aThrow)
        {
            return GetType() != aThrow.GetType();
        }
    }
}