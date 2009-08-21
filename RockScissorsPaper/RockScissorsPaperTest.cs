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
            Assert.AreEqual(false, new Rock().BeatsPaper());
        }

        [Test]
        public void RockShouldNotBeatRock()
        {
            Assert.AreEqual(false, new Rock().BeatsRock());
        }

        [Test]
        public void RockShouldBeatScissors()
        {
            Assert.AreEqual(true, new Rock().BeatsScissors());
        }

        [Test]
        public void ScissorsShouldNotBeatScissors()
        {
            Assert.AreEqual(false, new Scissors().BeatsScissors());   
        }

        [Test]
        public void ScissorsShouldNotBeatRock()
        {
            Assert.AreEqual(false, ScissorsBeatRock());
        }

        [Test]
        public void ScissorsShouldBeatPaper()
        {
            Assert.AreEqual(true, ScissorsBeatsPaper());
        }

        private bool ScissorsBeatsPaper()
        {
            return true;
        }

        private bool ScissorsBeatRock()
        {
            return false;
        }

        private bool ScissorsBeatsScissors()
        {
            return false;
        }

        public class Scissors : WeaponOfMassDestruction
        {
            public bool BeatsPaper()
            {
                throw new System.NotImplementedException();
            }

            public bool BeatsScissors()
            {
                return false;
            }

            public bool BeatsRock()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}