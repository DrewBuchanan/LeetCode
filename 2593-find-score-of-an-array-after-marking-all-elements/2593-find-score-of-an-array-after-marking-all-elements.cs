public class Solution {
    public long FindScore(int[] nums) {
        long score = 0;
        int[][] sorted = new int[nums.Length][];
        bool[] marked = Enumerable.Repeat(false, nums.Length).ToArray();
        
        sorted = nums
            .Select((x, i) => new int[]{x, i})
            .OrderBy(e => e[0])
            .ThenBy(e => e[1])
            .ToArray();
        
        /*
        for (int i = 0; i < nums.Length; i++)
        {
            sorted[i] = new int[2];
            sorted[i][0] = nums[i];
            sorted[i][1] = i;
        }
        
        Array.Sort<int[]>(sorted, (x, y) => Comparer<int>.Default.Compare(x[0], y[0]));
        */
        
        for (int i = 0; i < sorted.Length; i++)
        {
            int index = sorted[i][1];
            if (!marked[index])
            {
                score += sorted[i][0];
                marked[index] = true;
                if (index > 0)
                    marked[index - 1] = true;
                if (index < marked.Length - 1) 
                    marked[index + 1] = true;
            }
        }
        
        return score;
    }
}