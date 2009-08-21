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

            Assert.AreEqual(rock, WinnerOfBattle(rock, scissors));
        }

        [Test]
        public void GivenARockAndPaperThePaperShouldWin()
        {
            var rock = new Rock();
            var paper = new Paper();

            Assert.AreEqual(paper, WinnerOfBattle(rock, paper));
        }

        [Test]
        public void GivenTwoRocksThereShouldBeNoWinner()
        {
            var rockOne = new Rock();
            var rockTwo = new Rock();

            Assert.AreEqual(false, BattleHasWinner(rockOne, rockTwo));
        }

        private bool BattleHasWinner(Rock throwOne, Rock throwTwo)
        {
            return false;
        }

        private WeaponOfMassDestruction WinnerOfBattle(Rock rock, WeaponOfMassDestruction otherWeapon)
        {
            var beatRock = otherWeapon.BeatsRock();
            return beatRock ? otherWeapon : rock;
        }

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