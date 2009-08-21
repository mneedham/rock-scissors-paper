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
        }

        [Test]
        public void PaperShouldNotBeatItself()
        {
            Assert.AreEqual(false, PaperBeatsPaper());
        }

        public class Paper
        {
            public bool BeatsRock()
            {
                return true;
            }
        }

        private bool PaperBeatsPaper()
        {
            return false;
        }

       
    }
}