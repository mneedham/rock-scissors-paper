using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class APaperShould
    {
        [Test]
        public void BeatRock()
        {
            var rock = new Rock();
            var paper = new Paper();
            var battle = new Battle(paper, rock);

            var battleResult = battle.Commence();

            Assert.AreEqual(true, battleResult.HasWinner);
            Assert.AreEqual(paper, battleResult.Winner);
        }
    }

    [TestFixture]
    public class ARockShould
    {
        [Test]
        public void BeatScissors()
        {
            var rock = new Rock();
            var scissors = new Scissors();
            var battle = new Battle(rock, scissors);

            var battleResult = battle.Commence();

            Assert.AreEqual(true, battleResult.HasWinner);
            Assert.AreEqual(rock, battleResult.Winner);
        }

        [Test]
        public void LoseToPaper()
        {
            var rock = new Rock();
            var paper = new Paper();
            var battle = new Battle(rock, paper);

            var battleResult = battle.Commence();

            Assert.AreEqual(true, battleResult.HasWinner);
            Assert.AreEqual(paper, battleResult.Winner);
        }

        [Test]
        public void DrawWithAnotherRock()
        {
            var battle = new Battle(new Rock(), new Rock());

            var battleResult = battle.Commence();

            Assert.AreEqual(false, battleResult.HasWinner);
        }
    }
}