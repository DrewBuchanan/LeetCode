public class Solution {
    public int MaximumBeauty(int[] nums, int k) {
        int maxBeauty = 0;
        
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            int target = nums[i] + (2 * k);
            int upperBound = findUpperBound(nums, target);
            maxBeauty = Math.Max(maxBeauty, upperBound - i + 1);
        }
        
        return maxBeauty;
    }
    
    public int findUpperBound(int[] nums, int val)
    {
        int low = 0;
        int high = nums.Length - 1;
        int result = 0;
        
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (nums[mid] <= val)
            {
                result = mid;
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        
        return result;
    }
}