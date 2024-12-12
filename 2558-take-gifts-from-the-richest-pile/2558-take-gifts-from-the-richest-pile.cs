public class Solution {
    public long PickGifts(int[] gifts, int k) {
        for (int i = 0; i < k; i++)
        {
            int maxIndex = Array.IndexOf(gifts, gifts.Max());
            gifts[maxIndex] = (int)Math.Floor(Math.Sqrt(gifts[maxIndex]));
            Console.WriteLine($"{maxIndex} {gifts[maxIndex]}");
        }
        
        return gifts.Select(i => (long)Convert.ToDouble(i)).Sum();
    }
}