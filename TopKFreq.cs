using System; 
using System.Collections.Generic; 
public class Solution {
    public IList<int> TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict =  new Dictionary<int, int>();
        int l = nums.Length;
        for(int i=0;i<l;i++)
        {
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i],1);
            }
            else{
                dict[nums[i]]=dict[nums[i]]+1;
            }
        }
        List<int> ans = new List<int>();
        int count=0;
        foreach(var pair in dict.OrderBy(p => -p.Value)) {
            // work with pair.Key and pair.Value
            if(count++<k)
            {
                ans.Add(pair.Key);
            }
            else{
                break;
            }
        }
        return ans;
    }
}