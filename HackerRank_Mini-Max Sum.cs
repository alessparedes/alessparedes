/*
Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
Then print the respective minimum and maximum values as a single line of two space-separated long integers.
* Function Description
Complete the miniMaxSum function in the editor below.
miniMaxSum has the following parameter(s):
  arr: an array of 5 integers

* Print
Print two space-separated integers on one line: the minimum sum and the maximum sum of  of  elements.

* Input Format
A single line of five space-separated integers.

* Constraints
1<= arr[i]<=10^9

* Output Format
Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly 
four of the five integers. (The output can be greater than a 32 bit integer.)

* Sample Input
1 2 3 4 5
* Sample Output
10 14
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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {   
        int[] newArr = new int[arr.Count];
        for (int i = 0; i < arr.Count; i++)
        {
            int aux = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                aux = (i != j) ? aux += arr[j] : aux;
            }
            newArr[i] = aux;  
        }
        Console.WriteLine(newArr.Min() + " " + newArr.Max());
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
