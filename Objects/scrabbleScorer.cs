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
      Regex rgx1pt = new Regex(@"(?i)[AEIOULNRST]");
      MatchCollection match1pt = rgx1pt.Matches(this.Word);
      this.Score += match1pt.Count;
      Regex rgx2pt = new Regex(@"(?i)[DG]");
      MatchCollection match2pt = rgx2pt.Matches(this.Word);
      this.Score += (match2pt.Count) * 2;
    }
  }
}
