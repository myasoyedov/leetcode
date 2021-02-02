public class Solution {
    public void Rotate(int[] nums, int k) {
        int[] a = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            int index = (i + k) % nums.Length;
            a[index] = nums[i];
        }
        for(int i = 0; i < nums.Length; i++){
            nums[i] = a[i];
        }
    }
}