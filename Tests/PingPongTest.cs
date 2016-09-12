using Xunit;
using PingPong;
using System;
using System.Collections.Generic;
namespace PingPong
{
  public class PingPongGameTest
  {
    [Fact]
    public void IsPingPong_InputIsOne_true()
    {
      //Arrange
      string[] expected = {"1"};
      //Act
      List<string> result = PingPongGame.PlayPingPong(1);
      // Console.WriteLine(result);
      //Assert
      Assert.Equal(expected, result);
    }

    [Fact]
    public void IsPingPong_InputIsTwo_true()
    {
      //Arrange
      string[] expected = {"1", "2"};
      //Act
      List<string> result = PingPongGame.PlayPingPong(2);
      //Assert
      Assert.Equal(expected, result);
    }



    // [Fact]
    // public void IsPingPong_ForNumberDivisibleByThree_true()
    // {
    //   PingPong testPingPong = new PingPong();
    //   Assert.Equal(true, testPingPong.IsPingPong(3));
    // }
    // [Fact]
    // public void IsPingPong_ForNumberDivisibleByFive_true()
    // {
    //   PingPong testPingPong = new PingPong();
    //   Assert.Equal(true, testPingPong.IsPingPong(5));
    // }
    // [Fact]
    // public void IsPingPong_ForNumberDivisibleByFifteen_true()
    // {
    //   PingPong testPingPong = new PingPong();
    //   Assert.Equal(true, testPingPong.IsPingPong(15));
    // }

  }
}
