import java.util.PriorityQueue;
class Solution {
    public int findKthLargest(int[] nums, int k) {
        int l = nums.length;
        PriorityQueue<Integer> pq = new PriorityQueue<>();
        for(int i=0;i<l;i++)
        {
            pq.add(nums[i]);
        }
        int val;
        k=l-k;
        while(k-->0)
        {
            val = pq.remove();
        }
        return pq.remove();
    }
}