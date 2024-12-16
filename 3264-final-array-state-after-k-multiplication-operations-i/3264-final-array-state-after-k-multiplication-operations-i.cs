public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        for (int i = 0; i < k; i++)
        {
            int index = Array.IndexOf(nums, nums.Min());
            nums[index] = nums[index] * multiplier;
        }
        
        return nums;
    }
}