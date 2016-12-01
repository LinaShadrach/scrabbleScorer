using Xunit;
using System;
using System.Collections.Generic;
using ScrabbleScorer.Objects;

namespace  ScrabbleScorer
{
  public class WordScoreTest
  {
    [Fact]
    public void Scorer_OnePointLetters_true()
    {
      //Arrange
      WordScore newWord = new WordScore("a");
      int expectedResult = 1;
      //Act
      newWord.Scorer();
      //Assert
      Assert.Equal(expectedResult, newWord.Score);
    }
    [Fact]
    public void Scorer_TwoPointLetters_true()
    {
      //Arrange
      WordScore newWord = new WordScore("d");
      int expectedResult = 2;
      //Act
      newWord.Scorer();
      //Assert
      Assert.Equal(expectedResult, newWord.Score);
    }
  }
}
