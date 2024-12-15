public class Solution {
    public double MaxAverageRatio(int[][] classes, int extraStudents) {
        PriorityQueue<int[], double> pq = new PriorityQueue<int[], double>();
        for (int i = 0; i < classes.Length; i++)
        {
            double diff = 1 - ((((double)classes[i][0]+1) / ((double)classes[i][1]+1)) - ((double)classes[i][0]/(double)classes[i][1]));
            pq.Enqueue(classes[i], diff);
        }
        
        for (int i = 0; i < extraStudents; i++)
        {
            int[] c = pq.Dequeue();
            c[0]++;
            c[1]++;
            double diff = 1 - ((((double)c[0]+1) / ((double)c[1]+1)) - ((double)c[0]/(double)c[1]));
            pq.Enqueue(c, diff);
        }
        
        double sum = 0.0;
        
        while (pq.Count > 0)
        {
            int[] c = pq.Dequeue();
            sum += (double)c[0]/(double)c[1];
        }
        
        sum /= classes.Length;
        
        
        return sum;
    }
}