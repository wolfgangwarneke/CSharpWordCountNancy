using System.Collections.Generic;

namespace WordCount.Objects
{
  public class WordCounter
  {
    private static string _allWordsOutput = "";
    private static string _uniqueWordsOutput = "";

    public static void CountWords(string inputString)
    {
      _allWordsOutput = "";
      _uniqueWordsOutput = "";
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
      _allWordsOutput = filteredWords.Count + " words";
      _uniqueWordsOutput = uniqueWords.Count + " unique words";
    }

    public static string GetAllWordsOutput()
    {
      return _allWordsOutput;
    }

    public static string GetUniqueWordsOutput()
    {
      return _uniqueWordsOutput;
    }
  }
}
