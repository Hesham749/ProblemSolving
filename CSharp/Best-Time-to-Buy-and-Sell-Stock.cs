public class Solution {
    public int MaxProfit(int[] prices) {
	int min = int.MaxValue;
	int maxProfit = 0;

	foreach (int price in prices)
	{
		if (price < min)
			min = price;
		else if (price - min > maxProfit)
			maxProfit = price - min;
	}
	return maxProfit;
    }
}