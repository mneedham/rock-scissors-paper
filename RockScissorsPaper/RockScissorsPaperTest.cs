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
            Assert.AreEqual(false, PaperShouldBeatPaper());
        }

        private bool PaperShouldBeatPaper()
        {
            return false;
        }

        private bool PaperBeatsRock()
        {
            return true;
        }
    }
}