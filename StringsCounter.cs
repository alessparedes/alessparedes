/*
Task
How many strings equal to A can be constructed using letters from the string B? Each letter can be used only once and in one string only.
INPUT/OUPUT
[input] string A
String to construct, A contains only lowercase English letters.
Constraints: 3 ≤ A.length ≤ 9.

[input] string B
String containing needed letters, B contains only lowercase English letters.
Constraints: 3 ≤ B.length ≤ 50.

[output] an integer
*/
public int StringsCounter(string A, string B){
          int count =0;
          bool lower1 = true;
          bool lower2 = true;
          int[] freq = new int[9];
          int long1 = A.Length;
          
          int[] freq2 = new int[50];
          int long2 = B.Length;
          
          if(long1 >=3 && long1 <= 9 && long2 >=3 && long2 <= 50){
            for (int i =0; i<long1; i++){
              if (Char.IsLower(A[i])) {
                lower1 = false;
              }
              freq[A[i] - 'a'] +=1;
              Console.Write(A[i]+" "+freq[A[i] - 'a']);
              Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            for (int i =0; i<long2; i++){
              if (!Char.IsLower(B[i])) {
                lower2 = false;
              }
              freq2[B[i] - 'a'] +=1;
              Console.Write(B[i]+" "+freq2[B[i] - 'a']);
              Console.WriteLine("");
            }
            count = int.MaxValue;
            Console.WriteLine(" ");
            for (int i=0; i<long2; i++){
              if(freq2[B[i] - 'a'] >1){
                Console.WriteLine(freq2[B[i] - 'a']+"/"+freq[B[i] - 'a']);
                count = Math.Min(count, freq2[B[i] - 'a']/freq[B[i] - 'a']);
                Console.WriteLine(count);
              }else{
                count = 0;
              }
            }
            if (!lower1 && !lower2){
              return 0;
            }
            return count;
          }
          return count;
        }
