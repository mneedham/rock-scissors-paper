using NUnit.Framework;
using RockScissorsPaper;

namespace RockScissorsPaper
{
    [TestFixture]
    public class ScissorsShould : ThrowDownTestBase
    {
        [Test]
        public void BeatPaper()
        {
            var scissors = new Scissors();
            var paper = new Paper();

            var battleResult = ThrowDownBetween(scissors, paper);

            Assert.AreEqual(scissors, battleResult.Winner);
        }

        [Test]
        public void LoseToRock()
        {
            var scissors = new Scissors();
            var rock = new Rock();

            var battleResult = ThrowDownBetween(scissors, rock);

            Assert.AreEqual(rock, battleResult.Winner);
        }

        [Test]
        public void DrawWithAnotherScissors()
        {
            var battleResult = ThrowDownBetween(new Scissors(), new Scissors());

            Assert.AreEqual(false, battleResult.HasWinner);
        }
    }
}