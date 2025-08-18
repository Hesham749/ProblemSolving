public class Solution {
    public int MaxProfit(int[] prices) {
    int[] freq = new int[2];
    int min = prices[0];
    int max = prices[0];
    int maxprofit = 0;

    for (int i = 0; i < prices.Length; i++)
    {
        if (prices[i] < min)
        {
            freq[0] = i;
            freq[1] = i;
            min = prices[i];
            max = prices[i];
        }
        if (prices[i] > max)
        {
            freq[1] = i;
            max = prices[i];
            if (freq[1] > freq[0])
            {
                maxprofit = maxprofit < max - min ? max - min : maxprofit;
            }
        }
    }

    return maxprofit;
    }
}