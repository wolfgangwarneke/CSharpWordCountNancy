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

      WordCounter.CountWords(input);
      Assert.Equal(expectedResult, WordCounter.GetAllWordsOutput());
    }
    [Fact]
    public void CountWords_HeyHeyItsMeKrustyTheClown_7Words6UniqueWords()
    {
      string input = "Hey, hey! It's me, Krusty the Clown.";
      string expectedResult = "7 words, 6 unique words";

      WordCounter.CountWords(input);
      string allCount = WordCounter.GetAllWordsOutput();
      string uniqueCount = WordCounter.GetUniqueWordsOutput();
      string totalTest = allCount + ", " + uniqueCount;

      Assert.Equal(expectedResult, totalTest);
    }
  }
}
