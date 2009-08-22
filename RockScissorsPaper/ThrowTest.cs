using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class ThrowTest
    {
        [Test]
        public void PaperVersusTheRest()
        {
            Assert.AreEqual(true, new Paper().BeatsRock());
            Assert.AreEqual(false, new Paper().BeatsPaper());
            Assert.AreEqual(false, new Paper().BeatsScissors());

            Assert.AreEqual(true, new Paper().Beats(new Rock()));
            Assert.AreEqual(false, new Paper().Beats(new Paper()));
            Assert.AreEqual(false, new Paper().Beats(new Scissors()));
        }

        [Test]
        public void RockVersusTheRest()
        {
            Assert.AreEqual(false, new Rock().BeatsPaper());
            Assert.AreEqual(false, new Rock().BeatsRock());
            Assert.AreEqual(true, new Rock().BeatsScissors());

            Assert.AreEqual(false, new Rock().Beats(new Paper()));
            Assert.AreEqual(false, new Rock().Beats(new Rock()));
            Assert.AreEqual(true, new Rock().Beats(new Scissors()));
        }

        [Test]
        public void ScissorsVersusTheRest()
        {
            Assert.AreEqual(false, new Scissors().BeatsScissors());
            Assert.AreEqual(false, new Scissors().BeatsRock());
            Assert.AreEqual(true, new Scissors().BeatsPaper());

            Assert.AreEqual(false, new Scissors().Beats(new Scissors()));
            Assert.AreEqual(false, new Scissors().Beats(new Rock()));
            Assert.AreEqual(true, new Scissors().Beats(new Paper()));
        }
    }
}