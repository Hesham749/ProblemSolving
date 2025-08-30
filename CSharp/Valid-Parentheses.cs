public class Solution {
    public bool IsValid(string s) {
    if (s.Length < 2)
         return false;
	Stack<char> parentseses = new();
	foreach (char item in s)
	{
		if (item is '(' or '[' or '{')
		{
			parentseses.Push(item);
		}
		else
		{
        if (parentseses.Count == 0)
           return false;
			switch (item)
			{
				case ')':
					if (parentseses.Peek() != '(')
						return false;
					parentseses.Pop();
					break;
				case ']':
					if (parentseses.Peek() != '[')
						return false;
					parentseses.Pop();
					break;
				case '}':
					if (parentseses.Peek() != '{')
						return false;
					parentseses.Pop();
					break;
				default:
					return false;
			}
		}

	}
    return !parentseses.TryPop(out var _);;  
    }
}