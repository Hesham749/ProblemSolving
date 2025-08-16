public class Solution {
    public int[] TwoSum(int[] nums, int target) {
	Dictionary<int, int> valueIndex = new();
	for (int i = 0; i < nums.Length; i++)
	{

		int secondNum = target - nums[i];
		if (valueIndex.TryGetValue(secondNum, out int index))
		{
			return [i, index];
		}
		valueIndex.TryAdd(nums[i], i);
	}
	return [];
    }
}