public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        		var ints = new HashSet<int>();

		foreach (int item in nums)
		{
			if (!ints.Add(item))
				return true;
		}
		return false;
    }
}