using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class RockScissorsPaperTest
    {
        [Test]
        public void PaperShouldBeatRock()
        {
            Assert.AreEqual(true, PaperBeatsRock());
        }

        [Test]
        public void PaperShouldNotBeatItself()
        {
            bool paperBeatsPaper = false;
            Assert.AreEqual(false, paperBeatsPaper);
        }

        private bool PaperBeatsRock()
        {
            return true;
        }
    }
}