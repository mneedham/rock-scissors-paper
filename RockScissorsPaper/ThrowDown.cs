namespace RockScissorsPaper
{
    public class ThrowDown
    {
        private readonly ThrowDownAdjudicator throwDownAdjudicator;

        public ThrowDown(IThrow throwOne, IThrow throwTwo)
        {
            throwDownAdjudicator = new ThrowDownAdjudicator(throwOne, throwTwo);
        }

        private bool DoWeHaveWinner()
        {
            return throwDownAdjudicator.DoWeHaveAWinner();
        }

        public ThrowDownResult Commence()
        {
            return DoWeHaveWinner() ? ThrowDownResult.WithWinner(throwDownAdjudicator.Winner()) : ThrowDownResult.WithNoWinner();
        }
    }
}