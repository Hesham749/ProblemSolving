public class Solution {
    public bool IsValid(string s) {
	Stack<char> parentseses = new();
	if (s.Length < 2)
		return false;

	foreach (char c in s)
	{
		if (c is '(' or '[' or '{')
		{
			parentseses.Push(c);
		}
		else
		{
			if (parentseses.TryPop(out char fs))
			{
				if (!(
					   (c is ')' && fs is '(')
					|| (c is ']' && fs is '[')
					|| (c is '}' && fs is '{')
					)
					)
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}

	}
	return parentseses.Count == 0;
    }
}