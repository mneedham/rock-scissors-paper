using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class WeaponsBattlingTest
    {
        [Test]
        public void PaperBattlingTheOthers()
        {
            Assert.AreEqual("win", new Paper().Battling(new Rock()));
            Assert.AreEqual("draw", new Paper().Battling(new Paper()));
            Assert.AreEqual("loss", new Paper().Battling(new Scissors()));
        }

        [Test]
        public void ScissorsBattlingTheOthers()
        {
            Assert.AreEqual("win", new Scissors().Battling(new Paper()));
            Assert.AreEqual("draw", new Scissors().Battling(new Scissors()));
            Assert.AreEqual("loss", new Scissors().Battling(new Rock()));
        }

        [Test]
        public void RockBattlingTheOthers()
        {
            Assert.AreEqual("win", new Rock().Battling(new Scissors()));
            Assert.AreEqual("draw", new Rock().Battling(new Rock()));
            Assert.AreEqual("loss", new Rock().Battling(new Paper()));
        }

    }
}