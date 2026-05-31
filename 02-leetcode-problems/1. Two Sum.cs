public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //Bruteforce Approach
        /*for(int i=0;i<nums.Length;i++)
        {
            for(int j=i+1;j<nums.Length;j++)
            {
                if(nums[i]+nums[j]==target)
                {
                    return new int[] {i,j};
                }
            }
        }
        return new int[] {-1,-1};*/
        //optimized approach
        Dictionary<int,int>dict = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            int val = target - nums[i];
            if(dict.ContainsKey(val))
            {
                return new int[] {dict[val],i};
            }
            if(dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = i;
            }
            else
            {
                dict.Add(nums[i],i);
            }
        }
        return new int[] {-1,-1};
    }
}