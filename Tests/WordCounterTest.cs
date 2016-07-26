using Xunit;

namespace WordCount.Objects
{
  public class WordCounterTest
  {
    [Fact]
    public void Test_WordCounter_UserPhraseEqualsUserWord()
    {
      WordCounter testWordCounter = new WordCounter("what", "what");
      Assert.Equal(testWordCounter.GetUserInput(), testWordCounter.GetUserWordToCheck());
    }
    // [Fact]
    // public void Test_WordCounter_UserPhraseDoesNotEqualUserWord()
    // {
    //   WordCounter testWordCounter = new WordCounter("no", "dice");
    //   Assert.NotEqual(testWordCounter.GetUserInput(), testWordCounter.GetUserWordToCheck());
    // }
  }
}
