public class Solution {
    public int MaxTwoEvents(int[][] events) {
        events = events.OrderBy(e => e[0]).ToArray();
        int[][] dp = new int[events.Length][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[3];
            for (int j = 0; j < dp[i].Length; j++)
                dp[i][j] = -1;
        }
        
        return findEvents(events, 0, 0, dp);
    }
    
    int findEvents(int[][] events, int idx, int cnt, int[][] dp)
    {
        if (cnt == 2 || idx >= events.Length)
            return 0;
        if (dp[idx][cnt] == -1)
        {
            int end = events[idx][1];
            int lo = idx + 1, hi = events.Length - 1;
            while (lo < hi)
            {
                int mid = (hi + lo) / 2;
                if (events[mid][0] > end)
                    hi = mid;
                else
                    lo = mid + 1;
            }
            int include = events[idx][2];
            if (lo < events.Length && events[lo][0] > end)
                include += findEvents(events, lo, cnt + 1, dp);
            int exclude = findEvents(events, idx + 1, cnt, dp);
            dp[idx][cnt] = Math.Max(include, exclude);
        }
        
        return dp[idx][cnt];
    }
    
    int MaxTwo(int[][] events)
    {
        List<Tuple<int[], int[], int>> pairs = new List<Tuple<int[], int[], int>>();
        
        for (int i = 0; i < events.Length - 1; i++)
            for (int j = i + 1; j < events.Length; j++)
                if (!EventsOverlap(events[i], events[j]))
                    pairs.Add(Tuple.Create<int[], int[], int>(events[i], events[j], events[i][2] + events[j][2]));
        
        for (int i = 0; i < events.Length; i++)
            pairs.Add(Tuple.Create<int[], int[], int>(events[i], null, events[i][2]));
        
        return pairs.OrderByDescending(p => p.Item3).First().Item3;
    }
    
    bool EventsOverlap(int[] a, int[] b)
    {
        return (a[0] <= b[0] && b[0] <= a[1]) ||
            (a[0] <= b[1] && b[1] <= a[1]) ||
            (b[0] <= a[0] && a[0] <= b[1]) ||
            (b[0] <= a[1] && a[1] <= b[1]);
    }
}