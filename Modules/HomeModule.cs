using Nancy;
using System;
using PingPong;
using System.Collections.Generic;

namespace PingPong
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/show-result"] = _ => {
        PingPongGame newPingPongplay = new PingPongGame ();
        newPingPongplay.PlayPingPong(Request.Form["pingPong-number"]);
        List<string> newPingPongplay = PingPongGame.GetAll();
        return View["show-result.cshtml", newPingPongplay];

      };
    }

  }
}
