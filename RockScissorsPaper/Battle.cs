namespace RockScissorsPaper
{
    public class Battle
    {
        private readonly WinnerDetermination winnerDetermination;

        public Battle(IWeapon throwOne, IWeapon throwTwo)
        {
            winnerDetermination = new WinnerDetermination(throwOne, throwTwo);
        }

        public bool CanGetWinner()
        {
            return winnerDetermination.CanWeGetAWinner();
        }

        public BattleResult Commence()
        {
            return CanGetWinner() ? BattleResult.WithWinner(DetermineWinner()) : BattleResult.WithNoWinner();
        }

        public IWeapon DetermineWinner()
        {
            return winnerDetermination.Winner();
        }
    }
}