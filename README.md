# C# Poker Challenge

Welcome to the Poker challenge!

## Learning Objectives
- Build a simple program using classes, functions, loops, and flow control
- Use `git` & GitHub to commit work and open a Pull Request

## Instructions

1. Fork this repository and then:
2. Run the tests from the Test Explorer. There should be a lot of failures to begin with.
3. In GitHub, [open a Pull Request](https://docs.github.com/en/github/collaborating-with-issues-and-pull-requests/creating-a-pull-request) from your forked repository to the challenge repository.
4. Implement the criteria below locally and [push your code](https://docs.github.com/en/github/managing-files-in-a-repository/adding-a-file-to-a-repository-using-the-command-line) to your repository! Every push to a branch that has an open Pull Request will update it automatically with your changes.
5. Check the status of the automated tests on the Pull Request - update your implementation if needed.

# Basics
The exercise is based on poker.  Pairs of cards in a collection (hand) are winners if they are the match and are have the highest value in the hand.  

All cards have a numeric value, number cards having their face value, Jack=11, Queen=12, King=13 Ace=13.

This exercises uses Tuples, a lightweight type for storing, specifically a Tuple<string,string> which can be thought as a pair of strings to represent each card in the pair.

# Core Task
Given two pairs of cards, return true if there is a winning pair and return it.


## Extension Task
Given three cards, calculate the winning three.

