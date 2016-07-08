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
        WordCounter userWordCounter = new WordCounter(Request.Form["userString"], Request.Form["userWord"]);
        return View["index.cshtml", userWordCounter];
      };
    }
  }
}
