class Solution {
    public boolean searchMatrix(int[][] matrix, int target) {
        int n = matrix.length;
        if(n==0)
        {
            //return new PairInt(-1,-1);
            return false;
        }
        int m = matrix[0].length;
        if(m==0)
        {
            //return new PairInt(-1,-1);
            return false;
        }
        int l = 0, r = m * n - 1;
        while (l != r){
            int mid = (l + r - 1) >> 1;
            if (matrix[mid / m][mid % m] < target)
                l = mid + 1;
            else 
                r = mid;
        }
        //return new PairInt(r/m,r%m);
        return matrix[r / m][r % m] == target;
    }
}