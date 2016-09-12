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

    [Fact]
    public void IsPingPong_InputIsThree_true()
    {
      string[] expected = {"1", "2", "ping"};
      List<string> result = PingPongGame.PlayPingPong(3);
      Assert.Equal(expected, result);
    }

    [Fact]
    public void IsPingPong_InputIsFifteen_true()
    {
      string[] expected = {"1", "2", "ping", "4", "pong", "ping", "7", "8", "ping", "pong", "11", "ping", "13", "14", "ping-pong"};
      List<string> result = PingPongGame.PlayPingPong(15);
      Assert.Equal(expected, result);

    }
  }
}
