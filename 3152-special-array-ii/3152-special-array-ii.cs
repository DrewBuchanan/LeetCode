public class Solution {
    public bool[] IsArraySpecial(int[] nums, int[][] queries) {
        bool[] results = Enumerable.Repeat(true, queries.Length).ToArray();
        
        List<int> violatingIndices = new List<int>();
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] % 2 == nums[i-1] % 2)
            {
                violatingIndices.Add(i);
            }
        }
        
        int[] violArray = violatingIndices.ToArray();
        
        for (int i = 0; i < queries.Length; i++)
        {
            int start = queries[i][0];
            int end = queries[i][1];
            
            bool violIndex = BinarySearch(start + 1, end, violArray);
            results[i] = !violIndex;
        }
        
        return results;
    }
    
    public bool BinarySearch(int start, int end, int[] violatingIndices)
    {
        int left = 0, right = violatingIndices.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if (violatingIndices[mid] < start)
                left = mid + 1;
            else if (violatingIndices[mid] > end)
                right = mid - 1;
            else
                return true;
        }
        
        return false;
    }
}