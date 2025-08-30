public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
	var freq = new Dictionary<int, int>();
	for (int i = 0; i < nums.Length; i++)
	{
		int current = nums[i];
		if (freq.ContainsKey(current))
		{
			freq[current]++;
		}
		else
		{
			freq.Add(current, 1);

		}
	}

	return [.. freq.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key)];
    }
}