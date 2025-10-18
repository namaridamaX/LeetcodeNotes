public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var longestSubstring = 0;
        var count = 0;
        var stringArray = s.ToCharArray();
        var usedArray = new List<char>();

        foreach(var a in stringArray){

            if(a == null){
                continue;
            }

            if(!usedArray.Contains(a)){
                count++;
                usedArray.Add(a);
            }
            else{
                if(longestSubstring < count){
                    longestSubstring = count;
                }
                count = 0;
                count++;
                usedArray.Add(a);
            }
        }
        return longestSubstring;
    }
}