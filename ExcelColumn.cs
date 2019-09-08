public class Solution {
    public int TitleToNumber(string s) {
        int l = s.Length, pos = 0;      
        for(int i=0;i<l;i++)
        {
            pos += (s[i] - 'A' + 1)*(int)Math.Pow(26,l-i-1);
        }
        return pos;
    }
}