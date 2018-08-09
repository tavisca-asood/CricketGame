Feature: Multiplayer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag

Scenario: Player score is zero when game starts
	When Player1 starts a game of cricket
	Then Player1 score should be 0
	When Player2 starts a game of cricket
	Then Player2 score should be 0

Scenario: Player1 should be able to score runs
	Given Player1 has started a game of cricket
	When Player1 scores 4 runs
	Then Player1 score should increase by 4

Scenario: Player2 should be able to score runs
	Given Player2 has started a game of cricket
	When Player2 scores 6 runs
	Then Player2 score should increase by 6

Scenario: Player1 should be able to score runs multiple times
	Given Player1 has started a game of cricket
	And Player1 has scored 6 runs
	When Player1 scores 4 runs
	Then Player1 score should be 10

Scenario: Players should be able to score runs multiple times
	Given Player1 has started a game of cricket
	Given Player2 has started a game of cricket
	And Player1 has scored 4 runs
	And Player1 has scored 6 runs
	And Player2 has scored 3 runs
	And Player2 has scored 4 runs
	When Player2 scores 6 runs
	Then Player1 score should be 10
	Then Player2 score should be 13

Scenario: Players should not be able to score runs after getting out
	Given Player1 has started a game of cricket
	And Player1 scores 5 runs
	And Player1 scores 6 runs
	And Player1 scores 4 runs
	And Player1 gets out
	And Player1 has scored 3 runs
	Given Player2 has started a game of cricket
	And Player2 scores 4 runs
	And Player2 scores 3 runs
	And Player2 scores 4 runs
	And Player2 gets out
	And Player2 scores 6 runs
	Then Player1 score should be 15
	Then Player2 score should be 11


Scenario: Declaring the winner of the game
	Given Player1 has started a game of cricket
	Given Player1 has scored 4 runs
	Given Player1 has scored 3 runs
	Given Player1 has scored 6 runs
	Given Player1 gets out
	Given Player2 has started a game of cricket
	Given Player2 has scored 2 runs
	Given Player2 has scored 6 runs
	Given Player2 has scored 2 runs
	Given Player2 scores 2 runs
	When Player2 gets out
	Then Player2 should win the game

Scenario: The game is a tie
	Given Player1 has started a game of cricket
	Given Player1 has scored 4 runs
	Given Player1 has scored 3 runs
	Given Player1 has scored 6 runs
	Given Player1 gets out
	Given Player2 has started a game of cricket
	Given Player2 has scored 6 runs
	Given Player2 has scored 3 runs
	Given Player2 has scored 4 runs
	When Player2 gets out
	Then the game is a tie