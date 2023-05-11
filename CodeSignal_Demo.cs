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

*/
string[] solution(string[][] queries) {
    string[] result = new string[queries.Length];
    string[] stringAdd =  new string[queries.Length];
    string[] newResult =  new string[queries.Length];
    
    for (int i=0; i<queries.Length; i++){
        if (queries[i][0].ToString().ToUpper() == "ADD"){
            stringAdd[i] = queries[i][1].ToString();
            result[i] = "";
        }
        if (queries[i][0].ToString().ToUpper() == "EXISTS"){
            /* No lo pude probar
            if (Array.Exists(queries, x => x == "REMOVE")) {
                newResult[i] = Array.Exists(stringAdd, x => x == queries[i][1].ToString()).ToString().ToLower();
            } else {
                result[i] = Array.Exists(stringAdd, x => x == queries[i][1].ToString()).ToString().ToLower();    
            }*/
            result[i] = Array.Exists(stringAdd, x => x == queries[i][1].ToString()).ToString().ToLower();    
        }
        if (queries[i][0].ToString().ToUpper() == "REMOVE"){
            newResult = result.Where(x=> x != queries[i][1].ToString()).ToArray();
            newResult[i] = Array.Exists(stringAdd, x => x == queries[i][1].ToString()).ToString().ToLower();
            
            Console.WriteLine(newResult[i] + " -> " +queries[i][1].ToString());
            return newResult;
        }
    }
    return result;
}

