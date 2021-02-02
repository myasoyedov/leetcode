public class Solution {
    public int HeightChecker(int[] heights) {
        int[] sorted = (int[])heights.Clone();
        Array.Sort(sorted);
        int result = 0;
        for(int i = 0; i < heights.Length; i++){
            if(heights[i] != sorted[i])
                result++;
        }
        return result;
    }
}