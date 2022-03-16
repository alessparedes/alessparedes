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



class TriedNode
{
    Dictionary<char, TriedNode> child;
    List <String> list;
    bool isWord; 
    public TriedNode()
    {
        child = new Dictionary<>();
        list = new ArrayList<>();
        //isWord = false;
    }
}

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
        List<List<String>> listRes = new ArrayList<>();
        TriedNode root = buildTree(repository);
        TriedNode curr = root;
        boolean flag = flase;
        for (int i=0; i<customerQuery.Length(); i++)
        {
            char key = customerQuery[i];
            curr = curr.child.get(key);
            if (curr == null)
            {
                flag = true;
                break;
            }
            if (i>0)
            {
                List<String> temp = new ArrayList<>();
                List<String> words = curr.list;
                for (int j=0; j<3 && j<words.Count(); j++)
                {
                    temp.add(words.get(j).toLowerCase());
                    res.add(temp);
                }
            }
        }
        return res;
    }
    public static TrieNode buildTree(List<String> repository)
    {
        TriedNode root = new TriedNode();
        foreach   (String s in repository)
        {
            TriedNode curr = root;
            for (int i=0; i<s.Length(); i++)
            {
                char key = s[i];
                if (curr.child.get(key) == null)
                {
                    curr.child.put(key, new TriedNode());
                }
                curr = curr.child.get(key);
                curr.list.add(s);
            }
            curr.isWord = true;
        }
        return root;
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
