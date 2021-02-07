public class Solution {
    public int[] ShortestToChar(string s, char c) {
        int[] res = new int[s.Length];
        for(int i = 0; i < s.Length; i++){
            res[i] = -1;
        }
        
        int dist = s.Length;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == c){
                dist = 0;
            }
            else{
                dist++;
            }
            res[i] = dist;
        }
        dist = s.Length;
        for(int i = s.Length - 1; i >= 0; i--){
            if(s[i] == c){
                dist = 0;
            }
            else{
                dist++;
            }
            res[i] = Math.Min(res[i], dist);
        }
        
        
        return res;
    }
}