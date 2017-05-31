using Xunit;
using System;
using FindReplace.Objects;

namespace FindReplace
{
  public class FindReplaceTests
  {
    [Fact]
    public void Check_Find_Replace()
    {
      Conversion instance = new  Conversion();
      string testString = instance.FindAndReplace("I go to school", "go", "went");
      Assert.Equal("i went to school", testString);
    }

    [Fact]
    public void Check_Find_Contains_true()
    {
      Conversion instance = new  Conversion();
      string result = instance.FindAndReplace("I went to school", "go", "went");
      Assert.Equal("That text does not contain the word or phrase you were trying to find.", result);
    }

    [Fact]
    public void Check_Inputs_Lowercase_true()
    {
      Conversion instance = new  Conversion();
      string testString = instance.FindAndReplace("i GO to schOOL", "gO", "wEnT");
      Assert.Equal("i went to school", testString);
    }
  }
}
