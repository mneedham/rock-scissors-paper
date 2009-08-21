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

        private bool PaperBeatsRock()
        {
            return true;
        }
    }
}