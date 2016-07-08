using Xunit;

namespace WordCount.Objects
{
  public class WordCountTest
  {
    [Fact]
    public void Check_Testing_123()
    {
      string input = "hello";
      Assert.Equal(input, WordCounter.CountWords(input));
    }
  }
}
