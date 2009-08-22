namespace RockScissorsPaper
{
    public class Battle
    {
        private readonly IWeapon throwOne;
        private readonly IWeapon throwTwo;
        private readonly WinnerDetermination winnerDetermination;

        public Battle(IWeapon throwOne, IWeapon throwTwo)
        {
            this.throwOne = throwOne;
            this.throwTwo = throwTwo;
            winnerDetermination = new WinnerDetermination(this.throwOne, this.throwTwo);
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

    public class BattleResult
    {
        private readonly IWeapon winner;

        private BattleResult(IWeapon winner)
        {
            this.winner = winner;
        }

        public IWeapon Winner
        {
            get { return winner; }
        }

        public bool HasWinner
        {
            get { return winner != null; }
        }

        public static BattleResult WithWinner(IWeapon winner)
        {
            return new BattleResult(winner);
        }

        public static BattleResult WithNoWinner()
        {
            return new BattleResult(null);
        }
    }
}