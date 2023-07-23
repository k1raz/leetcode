namespace leetcode.Palindrome;

public class Palindrome
{
    public bool IsPalindrome(int x)
    {
        string str = x.ToString();
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}