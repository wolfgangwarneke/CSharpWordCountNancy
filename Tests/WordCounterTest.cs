using Xunit;

namespace WordCount.Objects
{
  public class WordCounterTest
  {
    [Fact]
    public void Test_WordCounter_UserPhraseEqualsUserWord()
    {
      WordCounter testingWordCounter = new WordCounter("what", "what");
      Assert.Equal(testingWordCounter.GetUserInput(), testingWordCounter.GetUserWordToCheck());
    }
    [Fact]
    public void Test_WordCounter_UserPhraseDoesNotEqualUserWord()
    {
      WordCounter testWordCounter = new WordCounter("no", "dice");
      Assert.NotEqual(testWordCounter.GetUserInput(), testWordCounter.GetUserWordToCheck());
    }
    [Fact]
    public void Test_CalculateWordMatches_WordMatchesIsOneWhenInputsAreEqual()
    {
      WordCounter testWordCounter = new WordCounter("what", "what");
      int expected = 1;
      int result = testWordCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
    [Fact]
    public void Test_CalculateWordMatches_WordMatchesIsZeroWhenInputsAreNotEqual()
    {
      WordCounter testWordCounter = new WordCounter("no", "dice");
      int expected = 0;
      int result = testWordCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
    [Fact]
    public void Test_CalculateWordMatches_WordMatchesIsTwoWhenInputPhraseIsTwoIterationsOfInputWord()
    {
      WordCounter testWordCounter = new WordCounter("yolo yolo", "yolo");
      int expected = 2;
      int result = testWordCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
    [Fact]
    public void Test_CalculateWordMatches_WordMatchesIsThreeWhenInputPhraseIsThreeIterationsOfInputWord()
    {
      WordCounter testWordCounter = new WordCounter("yolo yolo yolo", "yolo");
      int expected = 3;
      int result = testWordCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
  }
}
