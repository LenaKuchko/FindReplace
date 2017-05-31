using System;
using System.Collections.Generic;

namespace FindReplace.Objects
{
  public class Conversion
  {
    public string FindAndReplace(string body, string find, string replace)
    {
      body = body.Replace(find, replace);
      return body;
    }
  }
}
