/*
 * Created by SharpDevelop.
 * User: MrFalko
 * Date: 27.02.2020
 * Time: 20:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace Tasks.Are_they_same
{
	
	public class AreTheySame
	{
		  public static bool comp(int[] a, int[] b)
		  {
		  
		    if (a == null || b == null)         return false;    
		    if (a.Length == 0 && b.Length == 0) return true;
		    if (a.Length != b.Length)           return false;
		    
		    for (int i = 0; i < a.Length; i++)  
		          a[i] = (int)Math.Pow(a[i],2);
		        
		    Array.Sort<int>(a);
		    Array.Sort<int>(b);
		    for (int i = 0; i < a.Length; i++)  
		        if (a[i] != b[i])       return false;
		          
		    return true;
		  }

	}
}
