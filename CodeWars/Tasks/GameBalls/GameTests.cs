/*
 * Created by SharpDevelop.
 * User: MrFalko
 * Date: 26.02.2020
 * Time: 19:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace Tasks
{
	[TestFixture]
	public class GameTests
	{
		[Test]
    public void Test1()
    {
      Assert.AreEqual("First", Game.WhoIsWinner(2,1,1,1));
    }

    [Test]
    public void Test2()
    {
      Assert.AreEqual("Second", Game.WhoIsWinner(2,3,1,2));
    }

    [Test]
    public void Test3()
    {
      Assert.AreEqual("Second", Game.WhoIsWinner(20,33,10,2));
    }

    [Test]
    public void Test4()
    {
      Assert.AreEqual("First", Game.WhoIsWinner(200,33,123,25));
    }

	}
}
