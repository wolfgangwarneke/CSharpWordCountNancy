using Xunit;

namespace WordCount.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void Test_RepeatCounter_UserPhraseEqualsUserWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("what", "what");
      Assert.Equal(testRepeatCounter.GetUserInput(), testRepeatCounter.GetUserWordToCheck());
    }
    [Fact]
    public void Test_RepeatCounter_UserPhraseDoesNotEqualUserWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("no", "dice");
      Assert.NotEqual(testRepeatCounter.GetUserInput(), testRepeatCounter.GetUserWordToCheck());
    }
    [Fact]
    public void Test_CalculateWordMatches_WordMatchesIsOneWhenInputsAreEqual()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("what", "what");
      int expected = 1;
      int result = testRepeatCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
    [Fact]
    public void Test_CalculateWordMatches_WordMatchesIsZeroWhenInputsAreNotEqual()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("no", "dice");
      int expected = 0;
      int result = testRepeatCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
    [Fact]
    public void Test_CalculateWordMatches_WordMatchesIsTwoWhenInputPhraseIsTwoIterationsOfInputWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("yolo yolo", "yolo");
      int expected = 2;
      int result = testRepeatCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
    [Fact]
    public void Test_CalculateWordMatches_WordMatchesIsThreeWhenInputPhraseIsThreeIterationsOfInputWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("yolo yolo yolo", "yolo");
      int expected = 3;
      int result = testRepeatCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
    [Fact]
    public void Test_CalculateWordMatches_WordMatchesIsOneWhenTwoWordPhraseContainsOneInstanceOfSearchWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("yolo bro", "yolo");
      int expected = 1;
      int result = testRepeatCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
    [Fact]
    public void Test_CalculateWordMatches_WordMatchesIsOneWhenOneWordPhraseIsLexicallyButNotTypographicallyEqualToSearchWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("Howdy", "howdy");
      int expected = 1;
      int result = testRepeatCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
    [Fact]
    public void Test_CaculateWordMatches_WordMatchesIsZeroWhenPortionOneWordPhraseHasTheSameCharactersAsTheSearchWord()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("catcher", "cat");
      int expected = 0;
      int result = testRepeatCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
    [Fact]
    public void Test_CaculateWordMatches_WordMatchesIsThreeWhenSearchWordOccursThreeTimesInWholePhrase()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("I got a dog because there was a dog at the dog pound", "dog");
      int expected = 3;
      int result = testRepeatCounter.CalculateWordMatches();
      Assert.Equal(expected, result);
    }
  }
}
