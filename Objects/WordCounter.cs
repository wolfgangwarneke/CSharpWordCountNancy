using System.Collections.Generic;
using System;

namespace WordCount.Objects
{
  public class WordCounter
  {
    private string _userInput;
    private string _userWordToCheck;

    public WordCounter(string userInput, string userWordToCheck)
    {
      _userInput = userInput;
      _userWordToCheck = userWordToCheck;
    }

    public string GetUserInput()
    {
      return _userInput;
    }

    public string GetUserWordToCheck()
    {
      return _userWordToCheck;
    }

    public int CalculateWordMatches()
    {
      int matchesCount = 0;
      string[] separatedWords = this.GetUserInput().Split(null);
      foreach (var word in separatedWords)
      {
        if (word == this.GetUserWordToCheck()) matchesCount++;
      }
      return matchesCount;
    }
  }
}
