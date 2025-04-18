public class Solution {
    public string MergeAlternately(string word1, string word2) {
   var merged = "";
 var len = Math.Max(word1.Length, word2.Length);
 for (int i = 0; i < len; i++)
 {
     if (i < word1.Length)
         merged += word1[i];

     if (i < word2.Length)
         merged += word2[i];


 }
 return merged;
}}