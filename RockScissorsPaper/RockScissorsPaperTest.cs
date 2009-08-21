using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class RockScissorsPaperTest
    {
        [Test]
        public void GivenARockAndScissorsTheRockShouldWin()
        {
            var rock = new Rock();
            var scissors = new Scissors();
            var battle = new Battle(rock, scissors);

            var battleResult = battle.Commence();

            Assert.AreEqual(true, battleResult.HasWinner);
            Assert.AreEqual(rock, battleResult.Winner);
        }

        [Test]
        public void GivenARockAndPaperThePaperShouldWin()
        {
            var rock = new Rock();
            var paper = new Paper();
            var battle = new Battle(rock, paper);

            var battleResult = battle.Commence();

            Assert.AreEqual(true, battleResult.HasWinner);
            Assert.AreEqual(paper, battleResult.Winner);
        }

        [Test]
        public void GivenTwoRocksThereShouldBeNoWinner()
        {
            var battle = new Battle(new Rock(), new Rock());

            var battleResult = battle.Commence();

            Assert.AreEqual(false, battleResult.HasWinner);
        }

        public class Battle
        {
            private readonly IWeaponOfMassDestruction throwOne;
            private readonly IWeaponOfMassDestruction throwTwo;

            public Battle(IWeaponOfMassDestruction throwOne, IWeaponOfMassDestruction throwTwo)
            {
                this.throwOne = throwOne;
                this.throwTwo = throwTwo;
            }

            public bool HasWinner()
            {
                return new WeaponComparison(throwOne, throwTwo).AreDifferent();
            }

            public BattleResult Commence()
            {
                return HasWinner() ? BattleResult.WithWinner(Winner()) : BattleResult.WithNoWinner();
            }

            public IWeaponOfMassDestruction Winner()
            {
                var beatRock = throwTwo.BeatsRock();
                return beatRock ? throwTwo : throwOne;
            }
        }
    }

    public class BattleResult
    {
        private readonly IWeaponOfMassDestruction winner;

        private BattleResult(IWeaponOfMassDestruction winner)
        {
            this.winner = winner;
        }

        public IWeaponOfMassDestruction Winner
        {
            get { return winner; }
        }

        public bool HasWinner
        {
            get { return winner != null; }
        }

        public static BattleResult WithWinner(IWeaponOfMassDestruction winner)
        {
            return new BattleResult(winner);
        }

        public static BattleResult WithNoWinner()
        {
            return new BattleResult(null);
        }
    }
}