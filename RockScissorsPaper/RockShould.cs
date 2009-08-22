using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class RockShould : BattleBase
    {
        [Test]
        public void BeatScissors()
        {
            var rock = new Rock();
            var scissors = new Scissors();

            var battleResult = BattleBetween(rock, scissors);

            Assert.AreEqual(rock, battleResult.Winner);
        }

        [Test]
        public void LoseToPaper()
        {
            var rock = new Rock();
            var paper = new Paper();

            var battleResult = BattleBetween(rock, paper);

            Assert.AreEqual(paper, battleResult.Winner);
        }

        [Test]
        public void DrawWithAnotherRock()
        {
            var battleResult = BattleBetween(new Rock(), new Rock());

            Assert.AreEqual(false, battleResult.HasWinner);
        }
    }
}