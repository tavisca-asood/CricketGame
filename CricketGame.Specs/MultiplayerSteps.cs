using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CricketGame.Specs
{
    [Binding]
    public class MultiplayerSteps
    {
        private Cricket _player1;
        private Cricket _player2;
        [When(@"Player1 has started a game of cricket")]
        [Given(@"Player1 has started a game of cricket")]
        [When(@"Player1 starts a game of cricket")]
        public void GivenPlayer1HasStartedAGameOfCricket()
        {
            _player1 = new Cricket();
        }

        [When(@"Player2 has started a game of cricket")]
        [Given(@"Player2 has started a game of cricket")]
        [When(@"Player2 starts a game of cricket")]
        public void GivenPlayer2HasStartedAGameOfCricket()
        {
            _player2 = new Cricket();
        }

        [Given(@"Player1 has scored (.*) runs")]
        [Given(@"Player1 scores (.*) runs")]
        [When(@"Player1 scores (.*) runs")]
        public void GivenPlayer1HasScoredRuns(int runs)
        {
            _player1.Score(runs);
        }
        
        [Given(@"Player1 gets out")]
        [When(@"Player1 gets out")]
        public void GivenPlayer1GetsOut()
        {
            _player1.Out = true;
        }
        [Given(@"Player2 has scored (.*) runs")]
        [Given(@"Player2 scores (.*) runs")]
        [When(@"Player2 scores (.*) runs")]
        public void GivenPlayer2HasScoredRuns(int runs)
        {
            _player2.Score(runs);
        }

        [Given(@"Player2 gets out")]
        [When(@"Player2 gets out")]
        public void GivenPlayer2GetsOut()
        {
            _player2.Out = true;
        }

        [Then(@"Player(.*) should win the game")]
        public bool ThenPlayerShouldWinTheGame(int player)
        {
            if(player==1)
            {
                if (_player1.IsScoreGreater(_player2)==1)
                    return true;
            }
            if (player == 2)
            {
                if (_player2.IsScoreGreater(_player1)==1)
                    return true;
            }
            return false;
        }

        [Then(@"Player1 score should be (.*)")]
        [Then(@"Player1 score should increase by (.*)")]
        public void ThenPlayer1ScoreShouldBe(int score)
        {
            _player1.PlayerScore.Should().Be(score);
        }

        [Then(@"Player2 score should be (.*)")]
        [Then(@"Player2 score should increase by (.*)")]
        public void ThenPlayer2ScoreShouldBe(int score)
        {
            _player2.PlayerScore.Should().Be(score);
        }

        [Then(@"the game is a tie")]
        public bool ThenTheGameIsATie()
        {
            if (_player1.IsScoreGreater(_player2) == 0)
                return true;
            return false;
        }


    }
}
