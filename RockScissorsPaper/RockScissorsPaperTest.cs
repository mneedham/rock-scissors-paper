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

   
}