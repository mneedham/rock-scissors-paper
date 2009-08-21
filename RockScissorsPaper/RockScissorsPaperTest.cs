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
            Assert.AreEqual(false, new Paper().BeatsScissors());
        }

        [Test]
        public void RockShouldNotBeatPaper()
        {
            Assert.AreEqual(false, RockBeatsPaper());
        }

        [Test]
        public void RockShouldNotBeatRock()
        {
            Assert.AreEqual(false, RockBeatsRock());
        }

        private bool RockBeatsRock()
        {
            return false;
        }

        private bool RockBeatsPaper()
        {
            return false;
        }

        public class Rock
        {
            
        }

        public class Paper
        {
            public bool BeatsRock()
            {
                return true;
            }

            public bool BeatsScissors()
            {
                return false;
            }

            public bool BeatsPaper()
            {
                return false;
            }
        }

       
    }
}