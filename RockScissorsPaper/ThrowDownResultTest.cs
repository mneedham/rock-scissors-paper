using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class ThrowDownResultTest
    {
        [Test]
        public void ThrowDownResultWithNoWinnerShouldLiveUpToThat()
        {
            Assert.AreEqual(false, ThrowDownResult.WithNoWinner().HasWinner);
        }
    }
}