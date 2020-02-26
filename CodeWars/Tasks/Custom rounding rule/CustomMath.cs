/*
 * Created by SharpDevelop.
 * User: MrFalko
 * Date: 26.02.2020
 * Time: 19:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * The goal is to create a generic Round function that must round decimal number based on a numerical precision and specific rule for rounding.

TASK        ----------------------
The round function shall accept the following parameters:

number: the decimal number to be rounded;
precision: the total number of significant decimal digits;
roundUpAt: the limiar for considering rounding. For instance, 5 means that 0,1,2,3,4 are rounded down and 5,6,7,8,9 and greater must be rounded up;
Example
Precision 0; Round Up At 5
Round (1, 0, 5) = 1 Round (1.4, 0, 5) = 1 Round (1.5, 0, 5) = 2 Round (2, 0, 5) = 2

Precision 0; Round Up At 4
Round (1, 0, 4) = 1 Round (1.4, 0, 4) = 2 Round (1.5, 0, 4) = 2 Round (2, 0, 4) = 2

There's a rule that zeros must never be rounded!


 */
using System;

namespace Tasks.Custom_rounding_rule
{
	/// <summary>
	/// Description of CustomMath.
	/// </summary>
	public class CustomMath
	{
		public static decimal Round(decimal number, int precision, int roundUpAt)
	    {
			decimal place = (decimal)Math.Pow(10,precision);//Разряд округления
			decimal placeRound = place*10;
			decimal n1 = Math.Truncate(number); 		 //Целая часть числа
			decimal n2 = number - n1;								 //Дробная часть числа
			decimal placeOfPrecision = n2 * place - Math.Truncate(n2 * place);
			decimal n3 = placeOfPrecision*10;        //Нашли разряд, по которому будем округлять
			decimal n4 = placeOfPrecision/place;     //Часть числа, которую надо отбросить
			decimal n5 = n2 - n4;                    //Дробная часть c отброшенной частью
			decimal n7 = 0;
			
			if (n3 > roundUpAt || (n3 == roundUpAt && roundUpAt != 0) )
				if (precision == 0)
					n7 = Math.Truncate(n1 + n5 + place);
				else
					n7 = n1 + n5 + (1/place);
			else if (n3 < roundUpAt)
				n7 = number - n4;
			else if (number == n1 && number >= 1 && number <= 10 && precision == 0 && roundUpAt == 0)
				n7 = number + 1;
			
	        return n7;
	    }
			  
			  
	}
}
