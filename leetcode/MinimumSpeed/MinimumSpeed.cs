namespace leetcode.MinimumSpeed;

public class MinimumSpeed
{
    public int MinSpeedOnTime(int[] dist, double hour) {
        int left = 1; // Minimum possible speed
        int right = 10000000; // Maximum possible speed
        int result = -1; // Result variable
        
        while (left <= right) {
            int mid = left + (right - left) / 2;
            double time = CalculateTime(dist, mid);
            
            if (time <= hour) {
                result = mid;
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
        
        return result; // Return the minimum speed
    }
    
    private double CalculateTime(int[] dist, int speed) {
        double time = 0.0;
        
        for (int i = 0; i < dist.Length - 1; i++) {
            time += Math.Ceiling((double)dist[i] / speed);
        }
        
        time += (double)dist[dist.Length - 1] / speed;
        
        return time;
    }
}