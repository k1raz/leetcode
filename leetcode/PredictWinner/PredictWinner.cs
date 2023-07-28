namespace leetcode.MaximumRunning;

public class PredictWinner
{
    public bool PredictTheWinner(int[] nums) {
        int n = nums.Length;
        int[,] dp = new int[n, n];
    
        for (int i = 0; i < n; i++) {
            dp[i, i] = nums[i];
        }
    
        for (int i = n - 2; i >= 0; i--) {
            for (int j = i + 1; j < n; j++) {
                dp[i, j] = Math.Max(nums[i] - dp[i+1, j], nums[j] - dp[i, j-1]);
            }
        }
    
        return dp[0, n - 1] >= 0;
    }
}