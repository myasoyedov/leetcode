public class Solution {
    public int MissingNumber(int[] nums) {
        //Gauss' Formula
        int expected = nums.Length * (nums.Length + 1) / 2;
        
        int actual = 0;
        foreach(int i in nums)
            actual += i;
        return expected - actual;
    }
}