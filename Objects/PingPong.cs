using System.Collections.Generic;

namespace PingPong
{
  public class PingPongGame
  {
    //variable

    public static List<string> PlayPingPong(int userNum)
    {
      List<string> instances = new List<string> {};
      // list needed to be inside the bracket in order to
      //identify the function and w/o giving any error of
      //running the result twice.
      for (int i = 1; i <= userNum; i++) {
        if (i % 15 == 0) {
          instances.Add("ping-pong");
        }
        else if (i % 5 == 0) {
          instances.Add("pong");
        }
        else if (i % 3 == 0) {
          instances.Add("ping");
        }
        else {
          instances.Add(i.ToString());
          //need to change i into string by .ToString()
        }
        // instances.Add("1");
      }
      return instances;
      //return instances need to be outside of the bracket
      //so that it won't store the result & repeating it.
    }
  }
}
