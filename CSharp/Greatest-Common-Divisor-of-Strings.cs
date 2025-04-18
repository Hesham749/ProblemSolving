public class Solution {
    public  string GcdOfStrings(string str1, string str2)
 {
    //  bool isConsestOf = str1.Contains(str2);

    //  if (isConsestOf)
    //  {
    //      var hasDiffValue = HasDiffValue(str1, str2);
    //      if (!hasDiffValue)
    //          return str2;
    //  }

     int lastIndex = str2.Length - 1;
     string gcd = string.Empty;

     for (int i = str2.Length ; i >= 1; i--)
     {
         if (str2.Length % i == 0)
         {
             lastIndex = i;
             gcd = str2[..lastIndex];
             if (!HasDiffValue(str2, gcd) && !HasDiffValue(str1, gcd))
                 return gcd;
         }
     }

     return "";

 }

 private  bool HasDiffValue(string str1, string str2)
 {
     return str1.Split(str2).Any(s => !string.IsNullOrEmpty(s));
 }
}