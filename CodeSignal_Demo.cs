/*
Your task is to implement a simple container of integer numbers. As a first step, consider implementing the following two operations:

- ADD <value> should add the specified integer value to the container. Returns an empty string.
- EXISTS <value> should check whether the specific integer value exists in the container. Returns "true" if the value exists, "false" otherwise.
- REMOVE <value> should remove the specified integer value to the container. Returns "true" if the value exists, "false" otherwise.
The container is supposed to be empty at the beginning of execution.
Given a list of queries, return the list of answers for these queries. To pass to the next level you have to pass all tests at this level.
#Example
Input
queries = [
    ["ADD", "1"],
    ["ADD", "2"],
    ["ADD", "5"],
    ["ADD", "2"],
    ["EXISTS", "2"],
    ["EXISTS", "5"],
    ["EXISTS", "1"],
    ["REMOVE", "2"],
    ["REMOVE", "1"],
    ["EXISTS", "2"],
    ["EXISTS", "1"]
]

Output 
the output should be solution(queries) = ["", "", "", "", "true", "true", "true", "false", "false", "false", "false"]

NOTE: I can not solve this array.

queries:
[["ADD","2"], 
 ["ADD","3"], 
 ["ADD","9"], 
 ["REMOVE","10"], 
 ["REMOVE","5"], 
 ["REMOVE","5"], 
 ["REMOVE","9"], 
 ["REMOVE","2"], 
 ["REMOVE","2"], 
 ["REMOVE","9"], 
 ["EXISTS","10"], 
 ["EXISTS","2"], 
 ["EXISTS","3"], 
 ["EXISTS","9"], 
 ["ADD","10"], 
 ["EXISTS","10"]]
*/
string[] solution(string[][] queries) {
    string[] result = new string[queries.Length];
    string[] stringAdd = new string[queries.Length+1];
    Console.WriteLine(queries.Length);
    for (int i = 0; i < queries.Length; i++){
        Console.WriteLine(string.Join(",", stringAdd));
        if (queries[i][0].ToUpper() == "ADD"){
            stringAdd[i] = queries[i][1];
            result[i] = "";
        }
        if (queries[i][0].ToUpper() == "EXISTS"){
            result[i] = Array.Exists(stringAdd, x => x == queries[i][1].ToString()).ToString().ToLower();
        }
        if (queries[i][0].ToUpper() == "REMOVE"){
            List<string> list = new List<string>(stringAdd);
            list.Remove(queries[i][1]);
            stringAdd = list.ToArray();
            result[i] = Array.Exists(stringAdd, x => x != queries[i][1].ToString()).ToString().ToLower();
            
        }
        
        
    }
    
    return result;
}
