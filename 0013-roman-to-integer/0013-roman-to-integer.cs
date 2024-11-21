public class Solution {
        
	Dictionary<char, int> roman = new Dictionary<char, int>()
	{
		{ 'I', 1 },
		{ 'V', 5 },
		{ 'X', 10 },
		{ 'L', 50 },
		{ 'C', 100 },
		{ 'D', 500 },
		{ 'M', 1000 }
	};

	public int RomanToInt(string s)
	{
		int sum = 0;
		for (int i = 0; i < s.Length - 1; i++)
		{
			if (roman[s[i]] < roman[s[i + 1]])
				sum -= roman[s[i]];
			else
				sum += roman[s[i]];
		}

		return sum + roman[s[s.Length - 1]];
	}
    
}