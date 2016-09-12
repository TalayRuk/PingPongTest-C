using Xunit;
using PingPong.Objects;
using System;
using System.Collections.Generic;
namespace PingPong
{
  public class PingPongTest
  {
    [Fact]
    public void IsPingPongNumber-ForNumberDivisibleByThree_true()
    {
      PingPong testPingPong = new PingPongNumber();
      Assert.Equal(true, testPingPong.IsPingPongNumber(3));
    }
  }
}
