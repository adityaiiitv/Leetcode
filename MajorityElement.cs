public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> hash = new Dictionary<int, int>();
        int l = nums.Length;
        if(l==1)
        {
            return nums[0];
        }
        for(int i=0;i<l;i++)
        {
            if(!hash.ContainsKey(nums[i]))
            {
                hash.Add(nums[i],1);
            }
            else{
                hash[nums[i]]+=1;
                if(hash[nums[i]]>l/2)
                {
                    return nums[i];
                }
            }
        }
        return 0;
    }
}