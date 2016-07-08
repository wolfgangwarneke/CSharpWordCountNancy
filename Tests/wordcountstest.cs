using Xunit;

namespace WordCount.Objects
{
  public class WordCountTest
  {
    [Fact]
    public void CountWords_HelloHowAreYouToday_2Words()
    {
      string input = "Hello, how are you today?";
      string expectedResult = "5 words";

      WordCounter testWordCounter = new WordCounter(input);
      Assert.Equal(expectedResult, testWordCounter.GetAllWordsOutput());
    }
    [Fact]
    public void CountWords_HeyHeyItsMeKrustyTheClown_7Words6UniqueWords()
    {
      string input = "Hey, hey! It's me, Krusty the Clown.";
      string expectedResult = "7 words, 6 unique words";

      WordCounter testWordCounter = new WordCounter(input);
      string allCount = testWordCounter.GetAllWordsOutput();
      string uniqueCount = testWordCounter.GetUniqueWordsOutput();
      string totalTest = allCount + ", " + uniqueCount;

      Assert.Equal(expectedResult, totalTest);
    }
    [Fact]
    public void CountWords_MyCatsBreatheSmellsLikeCatFoodCHECKINGdog_7WordsDoesNotContainDog()
    {
      string input = "My cat's breathe smells like cat food.";
      string wordToCheck = "dog";
      string expectedResult = @"7 words. Does not contain ""dog"".";

      WordCounter testWordCounter = new WordCounter(input, wordToCheck);
      string allCount = testWordCounter.GetAllWordsOutput();
      string uniqueCount = testWordCounter.GetUniqueWordsOutput();
      string wordCheckBooleanMessage = testWordCounter.GetWordCheckBooleanMessage();
      string totalTest = allCount + ". " + wordCheckBooleanMessage;

      Assert.Equal(expectedResult, totalTest);
    }
    [Fact]
    public void CountWords_IGotADogBecauseThereWasADogAtTheDogPound_TheWordDogOccurs3Times()
    {
      string input = "I got a dog because there was a dog at the dog pound.";
      string wordToCheck = "dog";
      string expectedResult = @"The word ""dog"" occurs 3 times.";

      WordCounter testWordCounter = new WordCounter (input, wordToCheck);
      string occurencesOfWord = testWordCounter.GetOccurenceAmountMessage();;

      Assert.Equal(expectedResult, occurencesOfWord);
    }
  }
}
