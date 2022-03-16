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
        List<List<string>> suggestions = new List<List<string>>();
        repository.sort();
        for (int i=0; i<customerQuery.Lenght; i++){
            string subStr = customerQuery.Substring(0,i);
            List<string> matches = repository.FindAll(review => review.StartsWtith(subStr)).take(3).ToString();
            suggestions.add(matches);
        }
        return suggestions;
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
