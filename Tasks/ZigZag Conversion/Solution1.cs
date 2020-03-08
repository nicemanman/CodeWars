/*
 * Created by SharpDevelop.
 * User: MrFalko
 * Date: 08.03.2020
 * Time: 11:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;
namespace Tasks.ZigZag_Conversion
{
	/// <summary>
	/// Description of Solution1.
	/// </summary>
	public class Solution1
	{
		public string Convert(string s, int numRows) {
		    if (numRows == 1) return s;
		    char[] symbols = s.ToCharArray();
		    int length = symbols.Length;
		    string[] strings = new string[numRows];
		    int currentCol   = 0;
		    int currentRow   = 0;
		    bool moveUp = false;
		    for (int i = 0; i < length; i++){  
		        strings[currentRow] += symbols[i];
		        currentRow = (moveUp) ? --currentRow : ++currentRow;
		        if (currentRow == 0 || currentRow == numRows - 1) 
		        {
		        	moveUp = !moveUp; 
		        	currentCol++;
		        }
		    }     
		     return string.Join("", strings);
	    }
	}
}
