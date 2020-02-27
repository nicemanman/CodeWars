/*
 * Created by SharpDevelop.
 * User: MrFalko
 * Date: 27.02.2020
 * Time: 20:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace Tasks.Are_they_same
{
	[TestFixture]
	public class AreTheySameTests
	{
		[Test]
	  public void TestNormal() 
	  {
	    int[] a = new int[] {121, 144, 19, 161, 19, 144, 19, 11};
	    int[] b = new int[] {11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19};
	    bool r = AreTheySame.comp(a, b); // True
	    Assert.AreEqual(true, r);
	  }
	  [Test]
	  public void TestArraysNull() 
	  {
	    int[] a = null;
	    int[] b = null;
	    bool r = AreTheySame.comp(a, b); // True
	    Assert.AreEqual(false, r);
	  }
	  [Test]
	  public void TestArraysEmpty() 
	  {
	    int[] a = new int[] {};
	    int[] b = new int[] {};
	    bool r = AreTheySame.comp(a, b); // True
	    Assert.AreEqual(true, r);
	  }
	  [Test]
	  public void TestBad() 
	  {
	    int[] a = new int[] {132, 144, 19, 161, 19, 144, 19, 11};
	    int[] b = new int[] {11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19};
	    bool r = AreTheySame.comp(a, b); // True
	    Assert.AreEqual(false, r);
	  }

	}
}
