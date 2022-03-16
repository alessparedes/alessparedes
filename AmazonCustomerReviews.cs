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
     * Complete the 'searchSuggestions' function below.
     *
     * The function is expected to return a 2D_STRING_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY repository
     *  2. STRING customerQuery
     */

    public static List<List<string>> searchSuggestions(List<string> repository, string customerQuery)
    {
        List<List<String>> listRes = new List<List<String>>();
        for (int i=1; i<customerQuery.Length; i++)
        {
            String s = customerQuery.Substring(0, i+1).ToLower();
            List<String> temp = new List<String>();
            int a = 0;
            for (int j=0; j<repository.Count(); j++)
            {
                if (repository.IndexOf(j).ToLower().StartWith(s))
                {
                    temp.Add(repository.IndexOf(j).ToString().ToLower());
                    a++;
                }
            }
            /*Collentions.Sort(temp);
            List<String> v = new ArrayList<String>();
            for (int k=0; k<=3&&k<temp.Count(); k++)
            {
                v.Add(temp.IndexOf(k));
            }
            listRes.Add(v);*/
        }
        return listRes;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int repositoryCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> repository = new List<string>();

        for (int i = 0; i < repositoryCount; i++)
        {
            string repositoryItem = Console.ReadLine();
            repository.Add(repositoryItem);
        }

        string customerQuery = Console.ReadLine();

        List<List<string>> result = Result.searchSuggestions(repository, customerQuery);

        textWriter.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));

        textWriter.Flush();
        textWriter.Close();
    }
}
