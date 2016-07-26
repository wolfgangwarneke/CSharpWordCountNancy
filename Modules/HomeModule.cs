using Nancy;
using System;
using WordCount.Objects;
using System.Collections.Generic;

namespace WordCount
{
  public class HomeModule : NancyModule
  {

    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/submit"] = _ => {
        RepeatCounter userRepeatCounter = new RepeatCounter(Request.Form["userPhrase"], Request.Form["userWord"]);
        return View["index.cshtml", userRepeatCounter];
      };
    }
  }
}
