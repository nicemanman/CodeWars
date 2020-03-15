/*
 * Created by SharpDevelop.
 * User: MrFalko
 * Date: 14.03.2020
 * Time: 22:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace Add_two_numbers
{	//TODO - Сделать возможность сравнения для элементов списка ListNode
	//Эти тесты пока не работают по техническим причинам
	[TestFixture]
	public class Test1
	{
		[Test]
		public void Test0()
		{
			ListNode l1 = new ListNode(2,2);
			ListNode l2 = new ListNode(0,1);
			
			//ListNode l3 = AddTwoNumbers(l1, l2);
			ListNode l4 = Solution.MergeTwoLists(l1, l2);
			ListNode ok_result = new ListNode(0,1,2,2);
			Assert.AreEqual(ok_result, l4);
		}
		
		[Test]
		public void Test2()
		{
			ListNode l1 = new ListNode(0,1);
			ListNode l2 = new ListNode(2,2);
			
			//ListNode l3 = AddTwoNumbers(l1, l2);
			ListNode l4 = Solution.MergeTwoLists(l1, l2);
			Assert.AreEqual(new ListNode(0,1,2,2), l4);
		}
		
		[Test]
		public void Test3()
		{
			ListNode l1 = new ListNode(-2,-1);
			ListNode l2 = new ListNode(0,1);
			ListNode l4 = Solution.MergeTwoLists(l1, l2);
			Assert.AreEqual(new ListNode(-2,-1,0,1), l4);
		}
		
		[Test]
		public void Test4()
		{
			ListNode l1 = new ListNode(2);
			ListNode l2 = new ListNode(1);
			
			ListNode l4 = Solution.MergeTwoLists(l1, l2);
			Assert.AreEqual(new ListNode(1,2), l4);
		}
	}
}
