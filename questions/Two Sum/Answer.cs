public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var result = new int[]{};
        for(var i = 0; i < nums.Length - 1; i++ ){
            for(var l = (i+1); l < nums.Length; l++){
                var sum = nums[i] + nums[l];
                if(sum == target){
                    return new int[]{i, l};
                }
            }
        }
        return result;
    }
}