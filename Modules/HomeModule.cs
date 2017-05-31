using Nancy;
using System.Collections.Generic;
using FindReplace.Objects;

namespace FindReplace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        Conversion ReplaceThis = new Conversion();
        string OperationComplete = ReplaceThis.FindAndReplace(Request.Form["body"], Request.Form["find"], Request.Form["replace"]);
        return View["index.cshtml", OperationComplete];
      };
    }
  }
}
