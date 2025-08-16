public class Solution {
    public int[] TwoSum(int[] nums, int target) {
	Dictionary<int, int> valueIndex = new();
	int[] twosum = new int[2];
	for (int i = 0; i < nums.Length; i++)
	{

		int secondNum = target - nums[i];
		if (valueIndex.TryGetValue(secondNum, out int index))
		{
			if (i != index)
			{

				twosum[0] = i;
				twosum[1] = index;
				return twosum;
			}
		}
		if (!valueIndex.TryAdd(nums[i], i))
			valueIndex[nums[i]] = i;
	}
	return twosum;
    }
}