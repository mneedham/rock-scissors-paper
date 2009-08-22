namespace RockScissorsPaper
{
    public class Battle
    {
        private readonly WinnerDetermination winnerDetermination;

        public Battle(IWeapon throwOne, IWeapon throwTwo)
        {
            winnerDetermination = new WinnerDetermination(throwOne, throwTwo);
        }

        private bool CanGetWinner()
        {
            return winnerDetermination.CanWeGetAWinner();
        }

        public BattleResult Commence()
        {
            return CanGetWinner() ? BattleResult.WithWinner(winnerDetermination.Winner()) : BattleResult.WithNoWinner();
        }
    }
}