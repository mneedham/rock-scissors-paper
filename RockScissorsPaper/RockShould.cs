using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class ScissorsShould
    {
        [Test]
        public void BeatPaper()
        {
            var scissors = new Scissors();
            var paper = new Paper();

            var battleResult = BattleBetween(scissors, paper);

            Assert.AreEqual(scissors, battleResult.Winner);
        }

        private BattleResult BattleBetween(IWeapon scissors, IWeapon paper)
        {
            return new Battle(scissors, paper).Commence();
        }

        [Test]
        public void LoseToRock()
        {
            var scissors = new Scissors();
            var rock = new Rock();

            var battleResult = BattleBetween(scissors, rock);

            Assert.AreEqual(rock, battleResult.Winner);
        }

        [Test]
        public void DrawWithAnotherScissors()
        {
            var battleResult = BattleBetween(new Scissors(), new Scissors());

            Assert.AreEqual(false, battleResult.HasWinner);
        }
    }

    [TestFixture]
    public class RockShould
    {
        [Test]
        public void BeatScissors()
        {
            var rock = new Rock();
            var scissors = new Scissors();
            var battle = new Battle(rock, scissors);

            var battleResult = battle.Commence();

            Assert.AreEqual(rock, battleResult.Winner);
        }

        [Test]
        public void LoseToPaper()
        {
            var rock = new Rock();
            var paper = new Paper();
            var battle = new Battle(rock, paper);

            var battleResult = battle.Commence();

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