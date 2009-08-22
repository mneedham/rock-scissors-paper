using NUnit.Framework;

namespace RockScissorsPaper
{
    [TestFixture]
    public class WinnerDeterminationTest
    {
        [Test]
        public void ShouldTellThatRockBeatsScissors()
        {
            var rock = new Rock();
            var scissors = new Scissors();

            var winner = new WinnerDetermination(scissors, rock).Winner();
            
            Assert.AreEqual(rock, winner);
        }

        [Test]
        public void ShouldTellThatPaperBeatsRock()
        {
            var paper = new Paper();
            var rock = new Rock();

            var winner = new WinnerDetermination(paper, rock).Winner();

            Assert.AreEqual(paper, winner); 
        }

        [Test]
        public void ShouldThrowAnExceptionIfWeCannotDetermineAWinner()
        {
            Assert.Throws<NoWinnerException>( () => new WinnerDetermination(new Paper(), new Paper()).Winner());
            Assert.Throws<NoWinnerException>( () => new WinnerDetermination(new Rock(), new Rock()).Winner());
            Assert.Throws<NoWinnerException>(() => new WinnerDetermination(new Scissors(), new Scissors()).Winner());
        }
    }
}