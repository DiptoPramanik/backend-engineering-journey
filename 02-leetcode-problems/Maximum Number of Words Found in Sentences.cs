public class Solution {
    public int MostWordsFound(string[] sentences) {
        int mx = -1;
        foreach(string s in sentences)
        {
            string[] words = s.Split(' ');
            mx = Math.Max(mx,words.Length);
        }
        return mx;
    }
}