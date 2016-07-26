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
    [Fact]
    public void Test_CalculateWordMatches_WordMatchesIsOneWhenTwoWordPhraseContainsOneInstanceOfSearchWord()
    {
      WordCounter testWordCounter = new WordCounter("yolo bro", "yolo");
      int expected = 1;
      int result = testWordCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
    [Fact]
    public void Test_CalculateWordMatches_WordMatchesIsOneWhenOneWordPhraseIsLexicallyButNotTypographicallyEqualToSearchWord()
    {
      WordCounter testWordCounter = new WordCounter("Howdy", "howdy");
      int expected = 1;
      int result = testWordCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
    [Fact]
    public void Test_CaculateWordMatches_WordMatchesIsZeroWhenPortionOneWordPhraseHasTheSameCharactersAsTheSearchWord()
    {
      WordCounter testWordCounter = new WordCounter("catcher", "cat");
      int expected = 0;
      int result = testWordCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
  }
}
