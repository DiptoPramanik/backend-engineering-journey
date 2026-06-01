public class Solution {
    public int[] Shuffle(int[] nums, int n) {
       int l = 2*n;
       int[] ans = new int[l];
       
       int idx = 0;
       for(int i=0;i<l;i+=2)
       {
            ans[i] = nums[idx];
            ans[i+1] = nums[idx+n];
            idx++;
       }

        return ans;
    }
}