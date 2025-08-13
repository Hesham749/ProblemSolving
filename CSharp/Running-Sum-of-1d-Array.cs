public class Solution {
    public int[] RunningSum(int[] nums) {
       List<int> sum = [nums[0]];
for (int i = 1; i < nums.Length; i++)
{
	sum.Add(sum[sum.Count - 1] + nums[i]);
}
return [.. sum];
    }
}