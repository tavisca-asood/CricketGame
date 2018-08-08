Feature: Multiplayer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: 2 players are playing the game
	Given Player1 has started a game of cricket
	Given Player1 has scored 4 runs
	Given Player1 has scored 3 runs
	Given Player1 has scored 6 runs
	Given Player1 gets out
	Given Player2 has started a game of cricket
	Given Player2 has scored 2 runs
	Given Player2 has scored 6 runs
	Given Player2 has scored 2 runs
	When Player2 scores 2 runs
	Then Player2 should win the game
