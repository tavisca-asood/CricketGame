using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CricketGame.Specs
{
    [Binding]
    public class PlayerScoreSteps
    {
        private Cricket _game;
        [When(@"Player starts a game of cricket")]
        [Given(@"Player has started a game of cricket")]
        public void WhenPlayerHasStartedAGameOfCricket()
        {
            _game = new Cricket();
        }
        
        [Then(@"the player score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int score)
        {
            _game.PlayerScore.Should().Be(score);
        }
        [When(@"Player scores (.*) runs")]
        [Given(@"Player has scored (.*) runs")]
        public void PlayerScore4Runs(int runs)
        {
            _game.Score(runs);
        }
        [Then(@"the score should increase by (.*)")]
        [Then(@"the score should be (.*)")]
        public void ThenTheScoreShouldIncreaseBy(int runs)
        {
            _game.PlayerScore.Should().Be(runs);
        }

        [Given(@"Player gets out")]
        public void GivenPlayerGetsOut()
        {
            _game.Out = true;
        }


    }
}
