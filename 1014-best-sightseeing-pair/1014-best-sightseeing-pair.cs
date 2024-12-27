public class Solution {
    public int MaxScoreSightseeingPair(int[] values)
    {
        int maxScore = 0;
        int[] maxLeftScore = new int[values.Length];
        maxLeftScore[0] = values[0];
        
        for (int i = 1; i < values.Length; i++)
        {
            int currentRightScore = values[i] - i;
            maxScore = Math.Max(maxScore, maxLeftScore[i - 1] + currentRightScore);
            int currentLeftScore = values[i] + i;
            maxLeftScore[i] = Math.Max(maxLeftScore[i - 1], currentLeftScore);
        }
        
        return maxScore;
    }
}