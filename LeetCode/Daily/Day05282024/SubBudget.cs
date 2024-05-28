namespace LeetCode.Daily.Day05282024
{
    public class SubBudget
    {
        public int EqualSubstring(string s, string t, int maxCost)
        {
            int maxLength = 0;
            int currentCost = 0;
            int start = 0;

            for (int end = 0; end < s.Length; end++)
            {
                currentCost += Math.Abs(s[end] - t[end]);

                while (currentCost > maxCost)
                {
                    currentCost -= Math.Abs(s[start] - t[start]);
                    start++;
                }

                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
            //int maxLength = 0;
            //for (var i = 0; i < s.Length; i++)
            //{

            //    if (s[i] == t[i])
            //    {
            //        maxLength++;
            //        continue;
            //    }
            //    else
            //    {
            //        var a = (int)s[i];
            //        var b = (int)t[i];
            //        var sum = Math.Abs(a - b);
            //        if (sum <= maxCost)
            //        {
            //            maxCost -= sum;
            //            maxLength++;
            //            //if (maxCost == 0)
            //            //{
            //            //    break;
            //            //}
            //        }

            //    }

            //}
            //return maxLength;
            //int maxLength = 0;
            //int[] sLength = new int[s.Length];
            //for (var i = 0; i < s.Length; i++)
            //{

            //    var a = (int)s[i];
            //    var b = (int)t[i];
            //    var sum = Math.Abs(a - b);
            //    sLength[i] = sum;

            //}
            //Array.Sort(sLength);
            //int j = 0;
            //while (j < s.Length)
            //{
            //    var sum = maxCost - sLength[j];
            //    if (sum >= 0)
            //    {
            //        maxCost = sum;
            //        maxLength++; j++;
            //    }
            //    else
            //    {
            //        break;
            //    }

            //}
            //return maxLength;

        }

    }
}
