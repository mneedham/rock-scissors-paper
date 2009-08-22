using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class RockShould : ThrowDownTestBase
    {
        [Test]
        public void BeatScissors()
        {
            var rock = new Rock();
            var scissors = new Scissors();

            var battleResult = ThrowDownBetween(rock, scissors);

            Assert.AreEqual(rock, battleResult.Winner);
        }

        [Test]
        public void LoseToPaper()
        {
            var rock = new Rock();
            var paper = new Paper();

            var battleResult = ThrowDownBetween(rock, paper);

            Assert.AreEqual(paper, battleResult.Winner);
        }

        [Test]
        public void DrawWithAnotherRock()
        {
            var battleResult = ThrowDownBetween(new Rock(), new Rock());

            Assert.AreEqual(false, battleResult.HasWinner);
        }
    }
}