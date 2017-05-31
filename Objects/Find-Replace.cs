using System;
using System.Collections.Generic;

namespace FindReplace.Objects
{
  public class Conversion
  {
    public string FindAndReplace(string body, string find, string replace)
    {
      if (body.Contains(find))
      {
        body = body.Replace(find, replace);
        return body;
      }
      else
      {
        return "That text does not contain the word or phrase you were trying to find.";
      }
    }
  }
}
