using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ScrabbleScorer.Objects
{
  public class WordScore
  {
    public string Word {get; set;}
    public int Score {get; set;}

    public WordScore(string word)
    {
      this.Word = word;
      this.Score = 0;
    }

    public void Scorer()
    {
      string[] patternsArr= {"(?i)[AEIOULNRST]", "(?i)[DG]", "(?i)[BCMP]", "(?i)[FHVWY]", "(?i)[K]", "(?i)[JX]", "(?i)[QZ]"};
      int[] pointsArr = {1, 2, 3, 4, 5, 8, 10};
      for(int i = 0; i < 7; i++)
      {
        Regex rgxPts = new Regex(patternsArr[i]);
        MatchCollection matchPts = rgxPts.Matches(this.Word);
        this.Score += (matchPts.Count)*pointsArr[i];
      }
    }
  }
}
