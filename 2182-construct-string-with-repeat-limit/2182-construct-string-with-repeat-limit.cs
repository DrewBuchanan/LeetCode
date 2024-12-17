public class Solution {
    public string RepeatLimitedString(string s, int repeatLimit) {
        int[] frequency = new int[26];
			List<char> res = new List<char>();
			for (int i = 0; i < frequency.Length; i++)
			{
				frequency[i] = s.ToCharArray().Where(c => c == i + 97).Count();
			}

			int current = 25;
			while (current >= 0)
			{
				if (frequency[current] == 0)
				{
					current--;
					continue;
				}

				int use = Math.Min(frequency[current], repeatLimit);
				frequency[current] -= use;
				for (int i = 0; i < use; i++)
				{
					res.Add((char)(current + 97));
				}

				if (frequency[current] > 0)
				{
					int smaller = current - 1;
					while (smaller >= 0 && frequency[smaller] == 0)
					{
						smaller--;
					}
					if (smaller < 0)
						break;
					res.Add((char)(smaller + 97));
					frequency[smaller]--;
				}
			}

			return string.Join("", res);
    }
}