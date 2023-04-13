/*
Given a time in -hour AM/PM format, convert it to military (24-hour) time.
Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
      - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

* Example
  s = '12:01:00PM'
  Return '12:01:00'

  s = '12:01:00AM'
  Return '00:01:00'

* Function Description
  Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.
  TimeConversion has the following parameter(s):
  * string s: a time in 12 hour format

* Returns
  string: the time in 24 hour format

* Input Format
  A single string s that represents a time in 12-hour clock format (i.e.: hh:mm:ssAM or hh:mm:ssPM).

* Constraints
  All input times are valid
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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        int length = s.Length -4;
        string amORpm = s.Substring(s.Length - 2);
        string result = "";
        if (amORpm.ToUpper() == "AM")
        {
            int hh = int.Parse(s.Substring(0,2));
            if (hh == 12) hh = 0;
            string time = hh.ToString();
            if (time.Length == 1){
              time = "0" + time;
              result = time + s.Substring(2, length);
            } else{
                result = s.Substring(0, length+2);
            }
        }
        if (amORpm.ToUpper() == "PM")
        {
            int hh = int.Parse(s.Substring(0,2));
            if (hh != 12) {
                hh += 12;
            }
            string time = hh.ToString();
            result = time + s.Substring(2, length);
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
