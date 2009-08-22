using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class ARockShould
    {
        [Test]
        public void BeatScissors()
        {
            var rock = new Rock();
            var scissors = new Scissors();
            var battle = new RockScissorsPaperTest.Battle(rock, scissors);

            var battleResult = battle.Commence();

            Assert.AreEqual(true, battleResult.HasWinner);
            Assert.AreEqual(rock, battleResult.Winner);
        }

        [Test]
        public void LoseToPaper()
        {
            var rock = new Rock();
            var paper = new Paper();
            var battle = new RockScissorsPaperTest.Battle(rock, paper);

            var battleResult = battle.Commence();

            Assert.AreEqual(true, battleResult.HasWinner);
            Assert.AreEqual(paper, battleResult.Winner);
        }

        [Test]
        public void HaveNoWinnerAgainstAnotherRock()
        {
            var battle = new RockScissorsPaperTest.Battle(new Rock(), new Rock());

            var battleResult = battle.Commence();

            Assert.AreEqual(false, battleResult.HasWinner);
        }
    }
}