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
            Assert.AreEqual(false, new Paper().BeatsPaper());
        }

        [Test]
        public void PaperShouldNotBeatScissors()
        {
            Assert.AreEqual(false, PaperBeatsScissors());
        }

        private bool PaperBeatsScissors()
        {
            return false;
        }

        public class Paper
        {
            public bool BeatsRock()
            {
                return true;
            }

            public bool BeatsPaper()
            {
                return false;
            }
        }

       
    }
}