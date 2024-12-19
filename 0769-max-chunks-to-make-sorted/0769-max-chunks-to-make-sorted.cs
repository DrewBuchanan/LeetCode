public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int chunks = 0;
        List<int> nums = new List<int>();
        List<int> compare = new List<int>();
        int startNum = 0;
        for (int i = 0; i < arr.Length; i++) {
            compare.Add(i);
            nums.Add(arr[i]);
            if (!compare.Except(nums).Any())
            {
                chunks++;
                nums.Clear();
                compare.Clear();
            }
        }
        
        return chunks;
    }
}