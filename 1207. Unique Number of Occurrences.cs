public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var dict = new Dictionary<int, int>();
        foreach(int x in arr){
            if(dict.ContainsKey(x)){
                dict[x]++;
            }
            else{
                dict.Add(x, 1);
            }
        }
        var h = new HashSet<int>(dict.Values);
        return dict.Count == h.Count;
    }
}