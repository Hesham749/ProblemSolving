public class Solution {
    public string LongestCommonPrefix(string[] strs) {
    string prefix = "";
	for (int i = 0; i < strs[0].Length; i++)
	{
		for (int j = 1; j < strs.Length; j++)
		{
			string current = strs[j];
			if (current.Length <= i || current[i] != strs[0][i])
			{
				return prefix;
			}
		}
		prefix += strs[0][i];
	}
	return prefix;
    }
}