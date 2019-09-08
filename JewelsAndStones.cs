using System;
using System.Collections.Generic;
 
public class Solution {
    public int NumJewelsInStones(string J, string S) {
        HashSet<char> hSet = new HashSet<char>();
        int l=J.Length;
        for(int i=0;i<l;i++)
        {
            hSet.Add(J[i]);
        }
        int l1 = S.Length, count = 0;
        for(int i=0;i<l1;i++)
        {
            if(hSet.Contains(S[i]))
            {
                count++;
            }
        }
        return count;
    }
}