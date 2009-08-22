using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class PaperShould
    {
        [Test]
        public void BeatRock()
        {
            var rock = new Rock();
            var paper = new Paper();
            var battle = new Battle(paper, rock);

            var battleResult = battle.Commence();

            Assert.AreEqual(paper, battleResult.Winner);
        }

        [Test]
        public void LoseToScissors()
        {
            var paper = new Paper();
            var scissors = new Scissors();
            var battle = new Battle(paper, scissors);

            var battleResult = battle.Commence();

            Assert.AreEqual(scissors, battleResult.Winner);
        }

        [Test]
        public void DrawWithAnotherPaper()
        {
            var battle = new Battle(new Paper(), new Paper());

            var battleResult = battle.Commence();

            Assert.AreEqual(false, battleResult.HasWinner);
        }
    }
}