/*
 * Created by SharpDevelop.
 * User: MrFalko
 * Date: 26.02.2020
 * Time: 19:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * 
 * TASK  -------------------------------
 * 
 * Two players play a simple game. Each player is provided with a box with balls. First player's box contains exactly «n1» balls and second player's box contains exactly «n2» balls.
In one move first player can take from 1 to k1 balls from his box and throw them away. Similarly, the second player can take from 1 to k2 balls from his box in his move. Players alternate turns and the first player starts the game.
The one who can't make a move loses. Your task is to determine who wins if both players play optimally!

 */
using System;

public class Game
    {
        public static string WhoIsWinner(int n1, int n2, int k1, int k2)
        { 
            for (; n1 >= 0 && n2 >= 0; --n1, --n2);//Take away 1 ball at a time, it is SO optimal:D
            return (n1 < 0 ? "Second" : "First");
        }
        
        public static void Main(){}
    }