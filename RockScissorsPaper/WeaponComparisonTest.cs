using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class WeaponComparisonTest
    {
        [Test]
        public void PaperShouldBeRecognisedAsBeingDifferentToOtherWeapons()
        {
            Assert.AreEqual(true, new WeaponComparison(new Paper(), new Rock()).AreDifferent());
            Assert.AreEqual(true, new WeaponComparison(new Paper(), new Scissors()).AreDifferent());
            Assert.AreEqual(false, new WeaponComparison(new Paper(), new Paper()).AreDifferent());
        }
    }
}