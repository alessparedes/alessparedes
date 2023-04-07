/*
Staircase detail
This is a staircase of size n = 4:
   #
  ##
 ###
####
Its base and height are both equal to . It is drawn using # symbols and spaces. The last line is not preceded by any spaces.
Write a program that prints a staircase of size .

** Function Description
Complete the staircase function in the editor below.
staircase has the following parameter(s):
. int n: an integer

** Print
Print a staircase as described above.

** Input Format
A single integer, , denoting the size of the staircase.

** Constraints
0 < n <= 100

** Output Format
Print a staircase of size  using # symbols and spaces.

Note: The last line must have  spaces in it. If you consider something to improve you are free to mention it.
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

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        if (n > 0 && n <= 100){
            for (int i = 1; i <= n; i++){
                int stair = 0;
                for (int space = 1; space <= (n - i); space++) Console.Write(" ");
                while (stair < i){
                    Console.Write("#");
                    stair++;
                }
                Console.WriteLine("");
            }
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
