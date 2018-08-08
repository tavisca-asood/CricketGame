using System;
using TechTalk.SpecFlow;

namespace CricketGame.Specs
{
    [Binding]
    public class MultiplayerSteps
    {
        private Cricket _player1;
        private Cricket _player2;
        [Given(@"Player1 has started a game of cricket")]
        public void GivenPlayer1HasStartedAGameOfCricket()
        {
            _player1 = new Cricket();
        }

        [Given(@"Player2 has started a game of cricket")]
        public void GivenPlayer2HasStartedAGameOfCricket()
        {
            _player2 = new Cricket();
        }

        [Given(@"Player1 has scored (.*) runs")]
        [Given(@"Player1 scores (.*) runs")]
        public void GivenPlayer1HasScoredRuns(int runs)
        {
            _player1.Score(runs);
        }
        
        [Given(@"Player1 gets out")]
        public void GivenPlayer1GetsOut()
        {
            _player1.Out = true;
        }
        [Given(@"Player2 has scored (.*) runs")]
        [When(@"Player2 scores (.*) runs")]
        public void GivenPlayer2HasScoredRuns(int runs)
        {
            _player2.Score(runs);
        }

        [Given(@"Player2 gets out")]
        public void GivenPlayer2GetsOut()
        {
            _player2.Out = true;
        }

        [Then(@"Player(.*) should win the game")]
        public bool ThenPlayerShouldWinTheGame(int player)
        {
            if(player==1)
            {
                if (_player1.IsScoreGreater(_player2))
                    return true;
            }
            if (player == 2)
            {
                if (_player2.IsScoreGreater(_player2))
                    return true;
            }
            return false;
        }

    }
}
