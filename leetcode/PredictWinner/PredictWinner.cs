namespace leetcode.MaximumRunning;

public class PredictWinner
{
    public bool PredictTheWinner(int[] nums)
    {
        int n = nums.Length;
        int[,] dp = new int[n, n];

        for (int i = n - 1; i >= 0; i--)
        {
            dp[i, i] = nums[i];
            for (int j = i + 1; j < n; j++)
            {
                int a = nums[i] - dp[i + 1, j];
                int b = nums[j] - dp[i, j - 1];
                dp[i, j] = Math.Max(a, b);
            }
        }

        int totalSum = nums.Sum();
        return dp[0, n - 1] >= (totalSum + 1) / 2;
    }
}