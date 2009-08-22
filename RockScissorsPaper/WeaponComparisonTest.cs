using System;
using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class WeaponComparisonTest
    {
        [Test]
        public void PaperShouldBeRecognisedAsBeingDifferentToOtherWeapons()
        {
            Assert.AreEqual(true, new WinnerDetermination(new Paper(), new Rock()).CanWeGetAWinner());
            Assert.AreEqual(true, new WinnerDetermination(new Paper(), new Scissors()).CanWeGetAWinner());
            Assert.AreEqual(false, new WinnerDetermination(new Paper(), new Paper()).CanWeGetAWinner());
        }
    }
}