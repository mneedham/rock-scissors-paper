using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class RockScissorsPaperTest
    {
        [Test]
        public void PaperShouldBeatRock()
        {
            Assert.AreEqual(true, new Paper().BeatsRock());
            Assert.AreEqual(true, new Paper().Beats(new Rock()));
        }

        [Test]
        public void PaperShouldNotBeatItself()
        {
            Assert.AreEqual(false, new Paper().BeatsPaper());
            Assert.AreEqual(false, new Paper().Beats(new Paper()));
        }

        [Test]
        public void PaperShouldNotBeatScissors()
        {
            Assert.AreEqual(false, new Paper().BeatsScissors());
            Assert.AreEqual(false, new Paper().Beats(new Scissors()));
        }

        [Test]
        public void RockShouldNotBeatPaper()
        {
            Assert.AreEqual(false, new Rock().BeatsPaper());
            Assert.AreEqual(false, new Rock().Beats(new Paper()));
        }

        [Test]
        public void RockShouldNotBeatItself()
        {
            Assert.AreEqual(false, new Rock().BeatsRock());
            Assert.AreEqual(false, new Rock().Beats(new Rock()));
        }

        [Test]
        public void RockShouldBeatScissors()
        {
            Assert.AreEqual(true, new Rock().BeatsScissors());
            Assert.AreEqual(true, new Rock().Beats(new Scissors()));
        }

        [Test]
        public void ScissorsShouldNotBeatScissors()
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