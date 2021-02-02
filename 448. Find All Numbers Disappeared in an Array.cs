public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var result = new List<int>();
        foreach (var num in nums)
        {
            int i = Math.Abs(num) - 1;
            if (nums[i] > 0)
                nums[i] = -nums[i];
        }

        for (int i = 1; i <= nums.Length; i++)
        {
            int j = i - 1;
            if(nums[j] > 0)
                result.Add(i);
        }
        return result;
    }
}