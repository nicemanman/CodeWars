/*
 * Created by SharpDevelop.
 * User: MrFalko
 * Date: 07.03.2020
 * Time: 15:39
 * https://leetcode.com/problems/add-two-numbers/
 * https://leetcode.com/problems/merge-two-sorted-lists/
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
      	for (int i = 0; i < array.Length; i++)
      	{
      		head.val = array[i];
      		if (i < array.Length - 1)
      		{
      			head.next = new ListNode();
      			head = head.next;
      		}
      	}
      }
      
      public void printAll(){
      	ListNode head = this; //do not lose head!
      	
      	while (head != null)
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
	
	///<summary>https://leetcode.com/problems/merge-two-sorted-lists/	 
	/// </summary>	
	public static ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if (l1 == null && l2 != null) return l2;
        if (l1 != null && l2 == null) return l1;
        else if (l1 == null && l2 == null) return null;
        
        ListNode l3 = new ListNode();
        ListNode head = l3;     
        do 
        {
        	
        	if (l1 != null && (l2 == null || l1.val <= l2.val))
        	{	
	        	head.next = new ListNode(l1.val);
			    head = head.next;
			    l1 = l1.next;
        	}
        	else if (l1 == null || l1.val > l2.val)
        	{	
	        	head.next = new ListNode(l2.val);
			    head = head.next;
			    l2 = l2.next;
        	}	
        	

        } while (l1 != null || l2 != null);
        
        return l3.next;    
    }
	
//		static void Main(){
//			ListNode l1 = new ListNode(-1,0);
//			ListNode l2 = new ListNode(-2);
//		
//			ListNode l3 = AddTwoNumbers(l1, l2);
//			ListNode l4 = MergeTwoLists(l1, l2);
//			l4.printAll();
//			
//			Console.ReadLine();
//		}
}
}
