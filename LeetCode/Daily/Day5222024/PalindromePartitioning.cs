namespace LeetCode.Daily.Day5222024
{
    public class PalindromePartitioning
    {
        public int wordLength = 0;
        public IList<IList<string>> Partition(string s)
        {
            wordLength = s.Length;
            var result = new List<IList<string>>();

            Back(s, 0, new List<string>(), result);

            return result;
        }
        public void Back(string s, int index, List<string> acc, List<IList<string>> result)
        {
            if (index == wordLength)
            {
                result.Add(new List<string>(acc));
                return;
            }
            for (var i = index; i < wordLength; i++)
            {
                if (IsPalindrome(s, index, i))
                {
                    acc.Add(s.Substring(index, i - index + 1));
                    Back(s, i + 1, acc, result);
                    acc.RemoveAt(acc.Count - 1);
                }
            }
        }
        private bool IsPalindrome(string s, int left, int right)
        {
            while (left <= right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
