namespace RockScissorsPaper
{
    public class Battle
    {
        private readonly IWeapon throwOne;
        private readonly IWeapon throwTwo;

        public Battle(IWeapon throwOne, IWeapon throwTwo)
        {
            this.throwOne = throwOne;
            this.throwTwo = throwTwo;
        }

        public bool HasWinner()
        {
            return new WinnerDetermination(throwOne, throwTwo).CanWeGetAWinner();
        }

        public BattleResult Commence()
        {
            return HasWinner() ? BattleResult.WithWinner(DetermineWinner()) : BattleResult.WithNoWinner();
        }

        public IWeapon DetermineWinner()
        {
            var result = throwOne.Battling(throwTwo);
            if(result == "win")
            {
                return throwOne;
            }
            if(result == "draw")
            {
                return null;
            }
            return throwTwo;
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