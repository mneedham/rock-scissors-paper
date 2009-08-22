using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class WeaponOfMassDestructionTest
    {
        [Test]
        public void PaperVersusTheRest()
        {
            Assert.AreEqual(true, new Paper().BeatsRock());
            Assert.AreEqual(false, new Paper().BeatsPaper());
            Assert.AreEqual(false, new Paper().BeatsScissors());
        }

        [Test]
        public void RockVersusTheRest()
        {
            Assert.AreEqual(false, new Rock().BeatsPaper());
            Assert.AreEqual(false, new Rock().BeatsRock());
            Assert.AreEqual(true, new Rock().BeatsScissors());
        }

        [Test]
        public void ScissorsVersusTheRest()
        {
            Assert.AreEqual(false, new Scissors().BeatsScissors());
            Assert.AreEqual(false, new Scissors().BeatsRock());
            Assert.AreEqual(true, new Scissors().BeatsPaper());
        }   
    }
}