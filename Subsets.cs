public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> li = new List<IList<int>>();
        List<int> sli = new List<int>();
        li.Add(sli);
        int l = (int)Math.Pow(2,nums.Length);
        int curr, index;
        for(int i=1;i<l;i++)
        {
            sli = new List<int>();
            curr = i; index = 0;
            while(curr>0)
            {
                if(curr%2==1)
                {
                    sli.Add(nums[index]);
                }
                curr/=2;
                index++;
            }
            li.Add(sli);
        }
        return li;
    }
}