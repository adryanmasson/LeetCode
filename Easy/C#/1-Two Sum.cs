public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int[] resultado = new int[2];

        for(int i = 0; i < nums.Length; i++){
            if(nums.Contains(target - nums[i]) && i != Array.IndexOf(nums, (target - nums[i]))){
                resultado[0] = i;
                resultado[1] = Array.IndexOf(nums, (target - nums[i]));
                break;
            }
        }

        return resultado;
    }
}