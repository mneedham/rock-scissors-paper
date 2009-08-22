using System;
using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class ThrowDownAdjudicatorTest
    {
        [Test]
        public void PaperShouldBeRecognisedAsBeingDifferentToOtherWeapons()
        {
            Assert.AreEqual(true, new ThrowDownAdjudicator(new Paper(), new Rock()).DoWeHaveAWinner());
            Assert.AreEqual(true, new ThrowDownAdjudicator(new Paper(), new Scissors()).DoWeHaveAWinner());
            Assert.AreEqual(false, new ThrowDownAdjudicator(new Paper(), new Paper()).DoWeHaveAWinner());
        }
    }
}