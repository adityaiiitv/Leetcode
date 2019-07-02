import java.util.PriorityQueue;
class Solution {
    public int longestConsecutive(int[] nums) {
        int l = nums.length;
        PriorityQueue<Integer> pq = new PriorityQueue<>();
        for(int i=0;i<l;i++)
        {
            pq.add(nums[i]);
        }
        if(pq.isEmpty())
        {
            return 0;
        }
        int max_len = 1, curr_length = 1, prev = pq.remove(), curr;
        System.out.println(prev);
        while (!pq.isEmpty()) {
            curr = pq.remove();
            System.out.println(curr);
            if(curr - prev<=1)
            {
                if(prev!=curr)
                {
                    curr_length++;
                }
            }
            else{
                if(curr_length>max_len)
                {
                    max_len = curr_length;
                }
                curr_length = 1;
            }
            if(prev!=curr)
            {
                prev = curr;   
            }
        }
        if(curr_length>max_len)
        {
            max_len = curr_length;
        }
        return max_len;
    }
}