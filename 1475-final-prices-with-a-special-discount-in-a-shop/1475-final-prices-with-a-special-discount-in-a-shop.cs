public class Solution {
    public int[] FinalPrices(int[] prices) {
        for (int i = 0; i < prices.Length; i++)
        {
            prices[i] -= prices.Skip(i + 1).Where(c => c <= prices[i]).FirstOrDefault();
        }

        return prices;
    }
}