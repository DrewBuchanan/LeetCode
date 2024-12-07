public class Solution {
    public int MinimumSize(int[] nums, int maxOperations) {
        
        
        int left = 1;
        int right = nums.Max(); 
        int mid = (left + right) / 2;
        while (left < right)
        {
            mid = (left + right) / 2;
            if (CanAchieve(nums, mid, maxOperations))
                right = mid;
            else
                left = mid + 1;
        }
        
        return left;
    }
    
    public bool CanAchieve(int[] nums, int penalty, int max)
    {
        int operations = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > penalty)
                operations += (nums[i] - 1) / penalty;
        }
        
        return operations <= max;
    }
}