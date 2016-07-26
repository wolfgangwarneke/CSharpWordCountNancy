using System.Collections.Generic;
using System;

namespace WordCount.Objects
{
  public class RepeatCounter
  {
    private string _userInput;
    private string _userWordToCheck;

    public RepeatCounter(string userInput, string userWordToCheck)
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
        if (word.ToLower() == this.GetUserWordToCheck().ToLower()) matchesCount++;
      }
      return matchesCount;
    }
  }
}
