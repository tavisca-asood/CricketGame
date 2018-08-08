﻿Feature: PlayerScore
	In order to enjoy a game of cricket
	As a player
	I want to be told my score

@mytag
Scenario: Player score is zero when game starts
	When Player starts a game of cricket
	Then the player score should be 0

Scenario: Player should be able to score runs
	Given Player has started a game of cricket
	When Player scores 4 runs
	Then the score should increase by 4

Scenario: Player should be able to score runs multiple times
	Given Player has started a game of cricket
	And Player has scored 4 runs
	When Player scores 3 runs
	Then the score should be 7

Scenario: Player should not be able to score runs after getting out
	Given Player has started a game of cricket
	Given Player has scored 4 runs
	Given Player gets out
	When Player scores 3 runs
	Then the player score should be 4
