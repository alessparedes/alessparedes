/*
You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age. 
They will only be able to blow out the tallest of the candles. Count how many candles are tallest.

* Example
  Candles = [4,4,1,3]
  The maximum height candles are  units high. There are  of them, so return .

* Function Description
  Complete the function birthdayCakeCandles in the editor below.
  birthdayCakeCandles has the following parameter(s):
    int candles[n]: the candle heights

* Returns
  int: the number of candles that are tallest
  
* Input Format
  The first line contains a single integer, n, the size of candles[].
  The second line contains n space-separated integers, where each integer i describes the height of candles[i].

* Constraints
  1<= n <= 10^5
  1<= canfles[i] <= 10^7
 
* Sample Input 0
  4
  3 2 1 3
* Sample Output 0
  2
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
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {   
        int max = candles.Max(); //Declaration of the maximum numer in the list
        int count = 0;
        if (candles.Count>=1 && candles.Count<=100000)
        {
            for (int i = 0; i < candles.Count; i++)
            {
                if (candles[i]<0 || candles[i]>10000000) return -1;
                if (max == candles[i]) count+=1;
            }
        } 
        //Console.Error.WriteLine(count +" - "+max);
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
