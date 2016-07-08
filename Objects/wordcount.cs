using System.Collections.Generic;

namespace WordCount.Objects
{
  public class WordCounter
  {
    // private string[] _wordSeparators = { " ", ". ", "?" };
    // private string[] _wordsInString = new string[] {};

    public static string CountWords(string inputString)
    {
      string[] wordsInString = inputString.Split(' ', '/', '.', '?', '!', ';');
      List<string> unwantedEntries = new List<string> { "", " " };
      List<string> filteredWords = new List<string> {};
      foreach (var word in wordsInString)
      {
        if (!unwantedEntries.Contains(word)) {
          filteredWords.Add(word);
        }
      }
      return filteredWords.Count + " words";
    }
  }
}
