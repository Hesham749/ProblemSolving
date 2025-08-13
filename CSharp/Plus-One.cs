public class Solution {
    public int[] PlusOne(int[] digits) {
        var size = digits.Length;
var newDigits = new int[size + 1];
		for (int i = size - 1; i >= 0; i--)
		{
if (digits[i] < 9)
{
	++digits[i];
	return digits;
}
else
{
	digits[i] = newDigits[i+1] = 0;
}
		}
		newDigits[0] = 1;
		return newDigits;
    }
}