public class Solution {
    public long ContinuousSubarrays(int[] nums) {
        long subarrays = 0;
        long left = 0, right = 0, windowLength = 0, curMin = nums[0], curMax = nums[0];
        
        for (right = 0; right < nums.Length; right ++)
        {
            curMin = Math.Min(curMin, nums[right]);
            curMax = Math.Max(curMax, nums[right]);
            
            if (curMax - curMin > 2)
            {
                windowLength = right - left;
                subarrays += ((windowLength * (windowLength + 1)) / 2);
                
                left = right;
                curMin = curMax = nums[right];
                
                while (left > 0 && Math.Abs(nums[right] - nums[left - 1]) <= 2)
                {
                    left--;
                    curMin = Math.Min(curMin, nums[left]);
                    curMax = Math.Max(curMax, nums[left]);
                }
                
                if (left < right)
                {
                    windowLength = right - left;
                    subarrays -= ((windowLength * (windowLength + 1)) / 2);
                }
            }
        }
        
        windowLength = right - left;
        subarrays += ((windowLength * (windowLength + 1)) / 2);
        
        return subarrays;
    }
}