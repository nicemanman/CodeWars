/*
 * Created by SharpDevelop.
 * User: MrFalko
 * Date: 07.03.2020
 * Time: 15:39
 * https://leetcode.com/problems/add-two-numbers/
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
namespace Add_two_numbers{
 public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
      
      public ListNode(params int[] array){
      	ListNode head = this; //do not lose head!
      	foreach (int i in array)
      	{
      		head.val = i;
      		head.next = new ListNode();
      		head = head.next;
      	}
      }
      
      public void printAll(){
      	ListNode head = this; //do not lose head!
      	while (head.next != null)
      	{
      		Console.Write(head.val);
      		head = head.next;
      	}
      }
  }
 
public class Solution {
    
	public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = new ListNode(0);
        ListNode current = head;
        int carry = 0;
        while (l1 != null || l2 != null){
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;
            int sum = carry + x + y;
            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }
        if (carry > 0) {
            current.next = new ListNode(carry);
        }
        return head.next;
    }
		
		static void Main(){
			ListNode l1 = new ListNode(2,4,3);
			ListNode l2 = new ListNode(5,6,4);

			ListNode l3 = AddTwoNumbers(l1, l2);
			l3.printAll();
			
			Console.ReadLine();
		}
}
}
