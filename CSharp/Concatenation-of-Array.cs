public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var concatination = new List<int>(nums);
        concatination.AddRange(nums);
        return [..concatination];
    }
}