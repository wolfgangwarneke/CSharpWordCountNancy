using System.Collections.Generic;

namespace WordCount.Objects
{
  public class WordCounter
  {
    private static string _allWordsOutput = "";
    private static string _uniqueWordsOutput = "";
    private static string _wordCheckBooleanMessage = "";
    private static string _checkWord = "";
    private static string _occurenceAmountMessage = "";

    public static void CountWords(string inputString)
    {
      _allWordsOutput = "";
      _uniqueWordsOutput = "";
      _wordCheckBooleanMessage = "";
      inputString = inputString.ToLower();
      string[] wordsInString = inputString.Split(' ', '/', '.', ',', '?', '!', ';');
      List<string> unwantedEntries = new List<string> { "", " " };
      List<string> filteredWords = new List<string> {};
      List<string> uniqueWords = new List<string> {};
      foreach (var word in wordsInString)
      {
        if (!unwantedEntries.Contains(word)) {
          filteredWords.Add(word);
        }
      }
      foreach (var word in filteredWords)
      {
        if (!uniqueWords.Contains(word)) {
          uniqueWords.Add(word);
        }
      }
      foreach (var word in uniqueWords)
      {
        System.Console.WriteLine(word);
      }
      System.Console.WriteLine("");
      if (filteredWords.Contains(_checkWord))
      {
        _wordCheckBooleanMessage = string.Format(@"Does contain ""{0}"".", _checkWord);
      } else if (_checkWord != "")
      {
        _wordCheckBooleanMessage = string.Format(@"Does not contain ""{0}"".", _checkWord);
      }
      _allWordsOutput = filteredWords.Count + " words";
      _uniqueWordsOutput = uniqueWords.Count + " unique words";
      int howManyTimes = 0;
      foreach (var word in filteredWords)
      {
        if (word.ToLower() == _checkWord.ToLower()) howManyTimes++;
      }
      SetOccurenceAmountMessage(_checkWord, howManyTimes);
    }

    public static void CountWords(string inputString, string checkWord)
    {
      _checkWord = checkWord;
      WordCounter.CountWords(inputString);
    }

    public static void SetOccurenceAmountMessage(string word, int times)
    {
      _occurenceAmountMessage = string.Format(@"The word ""{0}"" occurs {1} times.", word, times);
    }

    public static string GetAllWordsOutput()
    {
      return _allWordsOutput;
    }

    public static string GetUniqueWordsOutput()
    {
      return _uniqueWordsOutput;
    }

    public static string GetWordCheckBooleanMessage()
    {
      return _wordCheckBooleanMessage;
    }

    public static string GetOccurenceAmountMessage()
    {
      return _occurenceAmountMessage;
    }
  }
}
