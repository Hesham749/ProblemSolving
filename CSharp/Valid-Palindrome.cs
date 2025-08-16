public class Solution {
    public bool IsPalindrome(string s) {
		int left = 0, right = s.Length - 1;
		while (left < right)
		{
			if (!char.IsAsciiLetterOrDigit(s[left]))
			{
				left++;
				continue;
			}
			if (!char.IsAsciiLetterOrDigit(s[right]))
			{
				right--;
				continue;
			}
			if (char.ToLower(s[left]) != char.ToLower(s[right]))
				return false;

			left++;
			right--;
		}
		return true;
    }
}