public class Solution {
    public int MaxProfit(int[] prices) {
        int l = prices.Length-1, total =0;
        for(int i=0;i<l;i++)
        {
            if(prices[i+1]>prices[i])
            {
                total+=prices[i+1]-prices[i];
            }
        }
        return total;
    }
}