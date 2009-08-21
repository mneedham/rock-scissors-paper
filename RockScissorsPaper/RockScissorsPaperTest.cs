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

            Assert.AreEqual(true, battle.HasWinner());
            Assert.AreEqual(rock, battle.Winner());

            var rockWinsBattle = CommenceBattle(rock, scissors);
            Assert.AreEqual(rock, rockWinsBattle.Winner);
        }

        private BattleResult CommenceBattle(Rock rock, Scissors scissors)
        {
            return BattleResult.WithWinner(rock);
        }

        [Test]
        public void GivenARockAndPaperThePaperShouldWin()
        {
            var rock = new Rock();
            var paper = new Paper();
            var battle = new Battle(rock, paper);

            Assert.AreEqual(true, battle.HasWinner());
            Assert.AreEqual(paper, battle.Winner());
        }

        [Test]
        public void GivenTwoRocksThereShouldBeNoWinner()
        {
            Assert.AreEqual(false, new Battle(new Rock(), new Rock()).HasWinner());
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

            public IWeaponOfMassDestruction Winner()
            {
                var beatRock = throwTwo.BeatsRock();
                return beatRock ? throwTwo : throwOne;
            }
        }
    }

    public class BattleResult
    {
        private readonly Rock rock;

        private BattleResult(Rock rock)
        {
            this.rock = rock;
        }

        public IWeaponOfMassDestruction Winner
        {
            get { return rock; }
        }

        public static BattleResult WithWinner(Rock rock)
        {
            return new BattleResult(rock);
        }
    }
}