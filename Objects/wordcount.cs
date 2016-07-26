// using System.Collections.Generic;
// using System;
//
// namespace WordCount.Objects
// {
//   public class badcode
//   {
//     private string _userInput = "";
//     private string _userWordToCheck = "";
//     private string _allWordsOutput = "";
//     private string _uniqueWordsOutput = "";
//     private string _wordCheckBooleanMessage = "";
//     private string _checkWord = "";
//     private string _occurenceAmountMessage = "";
//
//     public WordCounter(string userString)
//     {
//       _userInput = userString;
//       if (_userWordToCheck != "") {
//         WordCounter.CountWords(_userInput, _userWordToCheck);
//       }
//       else
//       {
//         WordCounter.CountWords(_userInput);
//       }
//     }
//
//     public WordCounter(string userString, string userWord)
//     {
//       _userInput = userString;
//       _userWordToCheck = userWord;
//       new WordCounter(_userInput);
//     }
//
//     public static void CountWords(string inputString)
//     {
//       _allWordsOutput = "";
//       _uniqueWordsOutput = "";
//       _wordCheckBooleanMessage = "";
//       inputString = inputString.ToLower();
//
//       List<string> unwantedEntries = new List<string> { "", " " };
//       List<string> filteredWords = new List<string> {};
//       List<string> uniqueWords = new List<string> {};
//
//       string[] wordsInString = inputString.Split(' ', '/', '.', ',', '?', '!', ';');
//       foreach (var word in wordsInString)
//       {
//         if (!unwantedEntries.Contains(word)) filteredWords.Add(word);
//       }
//       foreach (var word in filteredWords)
//       {
//         if (!uniqueWords.Contains(word)) uniqueWords.Add(word);
//       }
//       if (filteredWords.Contains(_checkWord))
//       {
//         _wordCheckBooleanMessage = string.Format(@"Does contain ""{0}"".", _checkWord);
//       }
//       else if (_checkWord != "")
//       {
//         _wordCheckBooleanMessage = string.Format(@"Does not contain ""{0}"".", _checkWord);
//       }
//       _allWordsOutput = filteredWords.Count + " words";
//       _uniqueWordsOutput = uniqueWords.Count + " unique words";
//       int howManyTimes = 0;
//       foreach (var word in filteredWords)
//       {
//         if (word.ToLower() == _checkWord.ToLower()) howManyTimes++;
//       }
//       SetOccurenceAmountMessage(_checkWord, howManyTimes);
//     }
//
//     public static void CountWords(string inputString, string checkWord)
//     {
//       _checkWord = checkWord;
//       WordCounter.CountWords(inputString);
//     }
//
//     private static void SetOccurenceAmountMessage(string word, int times)
//     {
//       _occurenceAmountMessage = string.Format(@"The word ""{0}"" occurs {1} times.", word, times);
//     }
//
//     public string GetAllWordsOutput()
//     {
//       return _allWordsOutput;
//     }
//
//     public string GetUniqueWordsOutput()
//     {
//       return _uniqueWordsOutput;
//     }
//
//     public string GetWordCheckBooleanMessage()
//     {
//       return _wordCheckBooleanMessage;
//     }
//
//     public string GetOccurenceAmountMessage()
//     {
//       return _occurenceAmountMessage;
//     }
//
//     public string GetUserInput()
//     {
//       return _userInput;
//     }
//
//     public string GetUserWordToCheck()
//     {
//       return _userWordToCheck;
//     }
//
//     public string GetBoldOutput()
//     {
//       string userWordUpper = _userWordToCheck.ToUpper();
//       string userWordLower = _userWordToCheck.ToLower();
//       string userWordCapital = FirstLetterToUpper(userWordLower);
//       string boldHTMLoutput = _userInput;
//       boldHTMLoutput = boldHTMLoutput.Replace(userWordUpper, WordWithBoldTag(userWordUpper)).Replace(userWordLower, WordWithBoldTag(userWordLower)).Replace(userWordCapital, WordWithBoldTag(userWordCapital));
//       List<string> notWordSignifiers = new List<string> { "-", "'", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
//       foreach (var c in notWordSignifiers)
//       {
//         System.Console.WriteLine(c);
//         string beginning = boldHTMLoutput;
//         boldHTMLoutput = boldHTMLoutput.Replace(WordWithBoldTag(_userWordToCheck) + c, _userWordToCheck + c).Replace(WordWithBoldTag(userWordUpper) + c, userWordUpper + c).Replace(WordWithBoldTag(userWordLower) + c, userWordLower + c).Replace(WordWithBoldTag(userWordCapital) + c, userWordCapital + c);
//         System.Console.WriteLine("looped");
//         string end = boldHTMLoutput;
//         if (beginning != end) System.Console.WriteLine("changed");
//       }
//       System.Console.WriteLine(boldHTMLoutput);
//       return boldHTMLoutput;
//     }
//
//     public string WordWithBoldTag(string word)
//     {
//       return string.Format("<strong>{0}</strong>", word);
//     }
//
//     public string FirstLetterToUpper(string str)
//     {
//       if (str == null)
//         return null;
//       if (str.Length > 1)
//         return char.ToUpper(str[0]) + str.Substring(1);
//       return str.ToUpper();
//     }
//   }
// }
