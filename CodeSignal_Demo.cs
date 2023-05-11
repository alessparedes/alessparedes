/*
Your task is to implement a simple container of integer numbers. As a first step, consider implementing the following two operations:

ADD <value> should add the specified integer value to the container. Returns an empty string.
EXISTS <value> should check whether the specific integer value exists in the container. Returns "true" if the value exists, "false" otherwise.
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
    ["EXISTS", "4"],
    ["EXISTS", "3"],
    ["EXISTS", "0"]
]

Output 
the output should be solution(queries) = ["", "", "", "", "true", "true", "true", "false", "false", "false"]

*/
string[] solution(string[][] queries) {
    int queriesLength = queries.Length;
    string[] result = new string[queriesLength];
    string[] stringAdd =  new string[queriesLength];
    
    for (int i=0; i<queriesLength; i++){
            if (queries[i][0].ToString().ToUpper() == "ADD"){
                stringAdd[i] = queries[i][1].ToString();
                result[i] = "";
            }
            if (queries[i][0].ToString().ToUpper() == "EXISTS"){
                result[i] = Array.Exists(stringAdd, x => x == queries[i][1].ToString()).ToString().ToLower();
            }
    }
    //Console.WriteLine(queries[1][0].ToString());
    return result;
}
