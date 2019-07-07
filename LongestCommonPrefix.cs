public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int ov = 1000;
        int lv=0;
        int l = strs.Length-1,len;
        String s = "";
        if(l==-1)
        {
            return s;
        }
        if(l==0)
        {
            return strs[0];
        }
        for(int i=0;i<l;i++)
        {
            len = Math.Min(strs[i].Length, strs[i+1].Length);
            if(ov!=1000)
            {
                len = Math.Min(len, ov);
            }    
            lv = 0;
            for(int j=0;j<len;j++)
            {
                if(strs[i][j] == strs[i+1][j])
                {
                    lv++;
                }
                else{
                    break;
                }
            }
            if(lv<ov)
            {
                ov = lv;
            }
        }
        return strs[0].Substring(0,ov);
    }
}