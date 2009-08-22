namespace RockScissorsPaper
{
    public class ThrowDownResult
    {
        private readonly IThrow winner;

        private ThrowDownResult(IThrow winner)
        {
            this.winner = winner;
        }

        public IThrow Winner
        {
            get { return winner; }
        }

        public bool HasWinner
        {
            get { return winner != null; }
        }

        public static ThrowDownResult WithWinner(IThrow winner)
        {
            return new ThrowDownResult(winner);
        }

        public static ThrowDownResult WithNoWinner()
        {
            return new ThrowDownResult(null);
        }
    }
}