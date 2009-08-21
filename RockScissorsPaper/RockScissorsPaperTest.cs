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
            private readonly WeaponOfMassDestruction throwOne;
            private readonly WeaponOfMassDestruction throwTwo;

            public Battle(WeaponOfMassDestruction throwOne, WeaponOfMassDestruction throwTwo)
            {
                this.throwOne = throwOne;
                this.throwTwo = throwTwo;
            }

            public bool HasWinner()
            {
                return throwOne.GetType() != throwTwo.GetType();
            }

            public WeaponOfMassDestruction Winner()
            {
                var beatRock = throwTwo.BeatsRock();
                return beatRock ? throwTwo : throwOne;
            }
        }
    }

    [TestFixture]
    public class WeaponsBattlingTest
    {
        [Test]
        public void ResultOfPaperBattlingRockShouldBeAWin()
        {
            Assert.AreEqual("win", new Paper().Battling(new Rock()));
        }

        [Test]
        public void ResultOfPaperBattlingPaperShouldBeADraw()
        {
            Assert.AreEqual("draw", new Paper().Battling(new Paper()));
        }

        [Test]
        public void ResultOfPaperBattlingScissorsShouldBeALoss()
        {
            Assert.AreEqual("loss", new Paper().Battling(new Scissors()));
        }

    }

    [TestFixture]
    public class WeaponOfMassDestructionTest
    {


        [Test]
        public void PaperShouldBeatRock()
        {
            Assert.AreEqual(true, new Paper().BeatsRock());
        }

        [Test]
        public void PaperShouldNotBeatItself()
        {
            Assert.AreEqual(false, new Paper().BeatsPaper());
        }

        [Test]
        public void PaperShouldNotBeatScissors()
        {
            Assert.AreEqual(false, new Paper().BeatsScissors());
        }

        [Test]
        public void RockShouldNotBeatPaper()
        {
            Assert.AreEqual(false, new Rock().BeatsPaper());
        }

        [Test]
        public void RockShouldNotBeatItself()
        {
            Assert.AreEqual(false, new Rock().BeatsRock());
        }

        [Test]
        public void RockShouldBeatScissors()
        {
            Assert.AreEqual(true, new Rock().BeatsScissors());
        }

        [Test]
        public void ScissorsShouldNotBeatItself()
        {
            Assert.AreEqual(false, new Scissors().BeatsScissors());
        }

        [Test]
        public void ScissorsShouldNotBeatRock()
        {
            Assert.AreEqual(false, new Scissors().BeatsRock());
        }

        [Test]
        public void ScissorsShouldBeatPaper()
        {
            Assert.AreEqual(true, new Scissors().BeatsPaper());
        }     
    }
}