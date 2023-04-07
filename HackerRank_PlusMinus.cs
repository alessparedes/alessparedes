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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int count = (arr.Count > 0 && arr.Count <= 100) ? arr.Count : 0;
        float positive = 0, negative = 0, zero = 0;
        for (int i = 0; i < count; i++)
        {
            if (arr[i] >= -100 && arr[i] <= 100)
            {
                positive = (arr[i] > 0) ? positive+1 : positive;
                negative = (arr[i] < 0) ? negative+1 : negative;
                zero = (arr[i] == 0) ? zero+1 : zero;
            }
        }
        //I think that to display the result it could be changed to something optimal, but if someone knows, please indicate it.
        Console.WriteLine("{0:0.000000}", positive/count);
        Console.WriteLine("{0:0.000000}", negative/count);
        Console.WriteLine("{0:0.000000}", zero/count);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
