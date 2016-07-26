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
  }
}
