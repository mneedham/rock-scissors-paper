using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class PaperShould: ThrowDownTestBase
    {
        [Test]
        public void BeatRock()
        {
            var rock = new Rock();
            var paper = new Paper();

            var battleResult = ThrowDownBetween(paper, rock);

            Assert.AreEqual(paper, battleResult.Winner);
        }

        [Test]
        public void LoseToScissors()
        {
            var paper = new Paper();
            var scissors = new Scissors();

            var battleResult = ThrowDownBetween(paper, scissors);

            Assert.AreEqual(scissors, battleResult.Winner);
        }

        [Test]
        public void DrawWithAnotherPaper()
        {
            var battleResult = ThrowDownBetween(new Paper(), new Paper());

            Assert.AreEqual(false, battleResult.HasWinner);
        }
    }
}