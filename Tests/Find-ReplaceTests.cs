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
      Assert.Equal("I went to school", testString);
    }
  }
}
