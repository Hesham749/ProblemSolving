public class Solution {
    public bool IsAnagram(string s, string t) {
        	if (s.Length != t.Length)
		return false;
	var frequency = new Dictionary<char, int>();

	for (int i = 0; i < s.Length; i++)
	{
		if (!frequency.TryAdd(s[i], 1))
		{
			frequency[s[i]]++;
		}
	}

	for (int i = 0; i < t.Length; i++)
	{
		if (frequency.TryGetValue(t[i], out int value))
		{
			if (value < 1)
				return false;
			frequency[t[i]]--;
		}
		else
		{
			return false;
		}
	}
	return true;
    }
}