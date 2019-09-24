public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        int l = grid.Length;
        int b = grid[0].Length;
        int[] top = new int[l];
        int[] side = new int[b];
        int max;
        for(int i=0;i<l;i++)
        {
            max = 0;
            for(int j=0;j<b;j++)
            {
                if(grid[i][j]>max)
                {
                    max = grid[i][j];
                }
            }
            top[i]=max;
        }
        for(int i=0;i<l;i++)
        {
            Console.Write(top[i]);
        }
        //
        for(int i=0;i<b;i++)
        {
            max = 0;
            for(int j=0;j<l;j++)
            {
                if(grid[j][i]>max)
                {
                    max = grid[j][i];
                }
            }
            side[i]=max;
        }
        for(int i=0;i<l;i++)
        {
            Console.Write(side[i]);
        }
        int sum = 0, curr_min;
        for(int i=0;i<l;i++)
        {
            for(int j=0;j<b;j++)
            {
                if(top[i]>side[j])
                {
                    curr_min = side[j];
                }
                else{
                    curr_min = top[i];
                }
                sum+=curr_min-grid[i][j];
            }
        }
        return sum;
    }
}