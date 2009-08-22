using System;

namespace RockScissorsPaper
{
    public class ThrowDownAdjudicator
    {
        private readonly IThrow throwOne;
        private readonly IThrow throwTwo;

        public ThrowDownAdjudicator(IThrow throwOne, IThrow throwTwo)
        {
            this.throwOne = throwOne;
            this.throwTwo = throwTwo;
        }

        public bool DoWeHaveAWinner()
        {
            return throwOne.IsDifferentThrowTo(throwTwo);
        }

        public IThrow Winner()
        {
            if (!DoWeHaveAWinner())
            {
                throw new NoWinnerException();
            }
            return throwOne.Beats(throwTwo) ? throwOne : throwTwo;
        }
    }

    internal class NoWinnerException : Exception
    {
        public NoWinnerException() : base("We can't get a winner")
        {
        }
    }
}