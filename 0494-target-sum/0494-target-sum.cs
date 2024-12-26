public class Solution
{
    public int FindTargetSumWays(int[] nums, int target)
    {
        int ways = 0;
        CalculateWays(nums, 0, 0, target, ref ways);
        return ways;
    }
    
    private void CalculateWays(int[] nums, int index, int currentSum, int target, ref int totalWays)
    {
        if (index == nums.Length)
        {
            if (currentSum == target)
                totalWays++;
            return;
        }
        
        CalculateWays(nums, index + 1, currentSum + nums[index], target, ref totalWays);
        CalculateWays(nums, index + 1, currentSum - nums[index], target, ref totalWays);
    }
}