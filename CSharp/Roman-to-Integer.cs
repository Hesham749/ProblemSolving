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
	int prevValue = 0;

	for (int i = s.Length - 1; i >= 0; i--)
	{
		int value = Roman[s[i]];
		if (value < prevValue)
			number -= value;
		else
			number += value;
		prevValue = value;
	}

	return number;
    }
}