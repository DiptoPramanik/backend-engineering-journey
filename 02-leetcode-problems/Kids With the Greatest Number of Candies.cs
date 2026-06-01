public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> ans = new List<bool>();
        int mx = candies.Max();

        for(int i=0;i<candies.Length;i++)
        {
            candies[i]-=mx;
        }

        for(int i=0;i<candies.Length;i++)
        {
            candies[i]+=extraCandies;
            ans.Add(candies[i]>=0);
        }

        return ans;
    }
}