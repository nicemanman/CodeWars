/*
 * Created by SharpDevelop.
 * User: MrFalko
 * Date: 05.03.2020
 * Time: 22:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace Tasks.Bit_Counting
{
	[TestFixture]
	public class Test1
	{
		[Test]
		public void CountBits()
		{
			Assert.AreEqual(0, Kata.CountBits(0));
		    Assert.AreEqual(1, Kata.CountBits(4));
		    Assert.AreEqual(3, Kata.CountBits(7));
		    Assert.AreEqual(2, Kata.CountBits(9));
		    Assert.AreEqual(2, Kata.CountBits(10));
		}
	}
}
