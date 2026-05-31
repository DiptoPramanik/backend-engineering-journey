public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] cntS = new int[26];
        int[] cntT = new int[26];

        foreach(char ch in s)
        {
            cntS[ch-'a']++;
        }

        foreach(char ch in t)
        {
            cntT[ch-'a']++;
        }

        for(int i=0;i<26;i++)
        {
            if(cntS[i]!=cntT[i])
            {
                return false;
            }
        }
        return true;
    }
}