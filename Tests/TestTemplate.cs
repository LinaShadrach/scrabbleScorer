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

    public void Scorer_OneLetter_true(int points, string letter)
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
