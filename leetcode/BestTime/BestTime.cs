namespace leetcode.BestTime;

public class BestTime
{
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length < 2) {
            return 0; // do not enough days, to make an order
        }

        int maxProfit = 0;
        int minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++) {
            maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            minPrice = Math.Min(minPrice, prices[i]);
        }
        return maxProfit;
    }
}