namespace LeetCode.Common.Tasks
{
    public class Palindrome
    {
        public bool IsPalindromeInt(int x)
        {
            var value = x.ToString();
            if (value.Length == 1)
            {
                return true;
            }
            var lastIndex = value.Length - 1;
            int mid = value.Length / 2;
            if (value.Length % 2 != 0)
            {
                mid += 1;
            }
            for (var i = 0; i <= mid; i++)
            {
                if (value[i] != value[lastIndex - i])
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsCorrectPalindrome(string s)
        {

            if (s.Length == 1)
            {
                return true;
            }
            var lastIndex = s.Length;
            int mid = s.Length / 2;
            if (s.Length % 2 != 0)
            {
                mid += 1;
            }
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }
            for (var i = 0; i <= mid; i++)
            {
                lastIndex -= 1;

                while (lastIndex != 0 && !Char.IsLetter(s[lastIndex]))
                {
                    lastIndex--;
                }
                while (i < s.Length - 1 && !Char.IsLetter(s[i]))
                {
                    i++;
                }

                if (Char.ToLower(s[i]) != Char.ToLower(s[lastIndex]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
