/*
 * Created by SharpDevelop.
 * User: MrFalko
 * Date: 17.03.2020
 * Time: 20:53
 * https://www.hackerrank.com/challenges/2d-array/problem
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

using System;

namespace Tasks.Hourglasses
{
	class Solution {

    // Complete the hourglassSum function below.
    static int hourglassSum(int[,] arr) {
        int max = 0, maxtemp = 0;
        int lastrow = 0, lastcol = 0;
            while (lastrow < 4)//first column sum
            {
                for (int row = lastrow; row < lastrow + 3; row++) //sum of n hourglass
                {
                    for (int col = lastcol; col < lastcol + 3; col++) 
                    {   
                        bool isMiddlePosition = 
                        ((lastrow % 2 == 0 && row % 2 != 0 && col == lastcol) 
                        ||  (lastrow % 2 != 0 && row % 2 == 0 && col == lastcol));

                        if (isMiddlePosition) 
                        {
                            maxtemp += arr[row,++col]; 
                            break;
                        }
                        else   
                            maxtemp += arr[row,col];
                    } 
                }
                bool thisSumIsFirst = (lastrow == 0 && lastcol == 0);
                bool gotTheEndOfCol = (lastrow == 3 && lastcol < 3);
                
                if (thisSumIsFirst || maxtemp > max) max = maxtemp;
                maxtemp = 0;

                if (gotTheEndOfCol)
                {
                    lastrow = 0;
                    lastcol++;
                }
                else
                    lastrow++;
                 
            }
            
        return max;

    }

    
    static void Main(string[] args) {
    	

    	int[,] arr = new int[6,6]{{1,0,0,0,0,0}, 
    							  {0,0,0,0,0,0}, 
    							  {0,0,0,0,0,0}, 
    							  {0,0,0,0,0,0}, 
    							  {0,0,0,0,0,0}, 
    							  {0,0,0,0,0,0}};
		
        
        int result = hourglassSum(arr);

        Console.WriteLine(result);
        Console.ReadLine();

    }
	}}
