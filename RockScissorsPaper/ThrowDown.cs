namespace RockScissorsPaper
{
    public class ThrowDown
    {
        private readonly ThrowDownAdjudicator throwDownAdjudicator;

        public ThrowDown(IWeapon throwOne, IWeapon throwTwo)
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