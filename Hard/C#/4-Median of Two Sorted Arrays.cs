public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] nums = nums1.Concat(nums2).ToArray();
        Array.Sort(nums);
        double result;
        
        if(nums.Length % 2 == 0){
            result = Convert.ToDouble((nums[nums.Length / 2 - 1] + nums[nums.Length / 2])) / 2;
        }else{
            result = nums[(nums.Length - 1) / 2];
        }

        return result;
    }
}