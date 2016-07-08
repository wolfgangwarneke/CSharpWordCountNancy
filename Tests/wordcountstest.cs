using Xunit;

namespace WordCount.Objects
{
  public class WordCountTest
  {
    [Fact]
    public void CountWords_HelloWorld_2()
    {
      string input = "Hello, how are you today?";
      string result = "5 words";
      Assert.Equal(result, WordCounter.CountWords(input));
      System.Console.WriteLine(result);
    }
  }
}
