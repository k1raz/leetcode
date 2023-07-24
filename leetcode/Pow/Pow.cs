namespace leetcode.Pow;

public class Pow
{
    public double MyPow(double x, int n) {
        // Cast n to long to avoid integer overflow
        long power = n;
    
        double result = 1.0;
    
        // If the power is negative, invert x and multiply power by -1
        if (power < 0) {
            x = 1 / x;
            power = -power;
        }
    
        while (power > 0) {
            // If the power is odd, multiply result with x
            if (power % 2 == 1) {
                result *= x;
            }
        
            // Divide the power by 2, and square x
            x *= x;
            power /= 2;
        }
    
        return result;
    }
}