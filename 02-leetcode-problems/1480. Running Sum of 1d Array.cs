public class Solution {
    public int[] RunningSum(int[] nums) {
        int sum=0;
        foreach(int i in nums) sum+=i;

        for(int i=nums.Length-1;i>=0;i--)
        {
            int temp = nums[i];
            nums[i] = sum;
            sum-=temp;
        }
        return nums;
    }
}