using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class BattleResultTest
    {
        [Test]
        public void BattleResultWithNoWinnerShouldLiveUpToThat()
        {
            Assert.AreEqual(false, BattleResult.WithNoWinner().HasWinner);
        }
    }
}