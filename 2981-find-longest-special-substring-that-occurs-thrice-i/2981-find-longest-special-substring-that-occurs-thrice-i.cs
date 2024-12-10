public class Solution {
    public int MaximumLength(string s) {
        List<string> subArrays = new List<string>();
			for (int i = 0; i < s.Length; i++)
			{
				int index = i;
				while (index < s.Length && s[index] == s[i])
				{
					subArrays.Add(s.Substring(i, index - i + 1));
					index++;
				}
			}

			return subArrays
				.GroupBy(sa => sa)
				.Where(g => g.Count() > 2)
				.OrderByDescending(g => g.Count())
				.SelectMany(g => g)
				.OrderByDescending(a => a.Length)
				.FirstOrDefault()?
				.ToString()?.Length ?? -1;
    }
}