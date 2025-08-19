public class Solution {
    public void MoveZeroes(int[] nums) {
        	int lastNonZeroFoundAt = 0;

	for (int current = 0; current < nums.Length; current++)
	{
		if (nums[current] != 0)
		{
			nums[lastNonZeroFoundAt] = nums[current];

			if (current != lastNonZeroFoundAt)
				nums[current] = 0;

			lastNonZeroFoundAt++;
		}
	}
    }
}