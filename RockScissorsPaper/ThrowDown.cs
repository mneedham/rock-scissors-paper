namespace RockScissorsPaper
{
    public class ThrowDown
    {
        private readonly WinnerDetermination winnerDetermination;

        public ThrowDown(IWeapon throwOne, IWeapon throwTwo)
        {
            winnerDetermination = new WinnerDetermination(throwOne, throwTwo);
        }

        private bool CanGetWinner()
        {
            return winnerDetermination.CanWeGetAWinner();
        }

        public ThrowDownResult Commence()
        {
            return CanGetWinner() ? ThrowDownResult.WithWinner(winnerDetermination.Winner()) : ThrowDownResult.WithNoWinner();
        }
    }
}