public class Solution {
    public int RomanToInt(string s) {
    var Roman = new Dictionary<char, int>(){
	{'I',1 },
	{'V',5 },
	{'X',10 },
	{'L',50 },
	{'C',100 },
	{'D',500 },
	{'M',1000 },
	};
	int number = 0;
	for (int i = 0; i < s.Length - 1; i++)
	{
		if (Roman[s[i]] < Roman[s[i + 1]])
		{
			number -= Roman[s[i]];
		}
		else
		{
			number += Roman[s[i]];
		}
	}
	number += Roman[s[s.Length - 1]];
	return number;
    }
}