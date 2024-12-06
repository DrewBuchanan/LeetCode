public class Solution {
    public int MaxCount(int[] banned, int n, int maxSum) {
        List<int> nums = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (!banned.Contains(i))
            {
                if (nums.Sum() + i <= maxSum)
                    nums.Add(i);
            }
        }

        return nums.Count();
    }
}