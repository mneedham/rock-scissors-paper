namespace RockScissorsPaper
{
    public class ThrowDownResult
    {
        private readonly IWeapon winner;

        private ThrowDownResult(IWeapon winner)
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

        public static ThrowDownResult WithWinner(IWeapon winner)
        {
            return new ThrowDownResult(winner);
        }

        public static ThrowDownResult WithNoWinner()
        {
            return new ThrowDownResult(null);
        }
    }
}