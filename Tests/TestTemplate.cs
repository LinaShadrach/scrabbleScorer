using Xunit;
using System;
using System.Collections.Generic;
using ScrabbleScorer.Objects;

namespace  ScrabbleScorer
{
  public class WordScoreTest
  {
    [Theory]
    [InlineData(1, "a")]
    [InlineData(2, "d")]
    [InlineData(3, "b")]
    [InlineData(4, "f")]
    [InlineData(5, "k")]
    [InlineData(8, "j")]
    [InlineData(10, "z")]
    [InlineData(9, "cave")]


    public void Scorer_ScoreWord_true(int points, string letter)
    {
      //Arrange
      WordScore newWord = new WordScore(letter);
      int expectedResult = points;
      //Act
      newWord.Scorer();
      //Assert
      Assert.Equal(expectedResult, newWord.Score);
    }

  }
}
