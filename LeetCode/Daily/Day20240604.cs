namespace LeetCode.Daily
{
    public class Day20240604
    {
        public int LongestPalindrome(string s)
        {

            int result = 0;
            int odd = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    map[s[i]]++;
                }
                else
                {
                    map[s[i]] = 1;
                }
            }
            foreach (var c in map)
            {
                if (c.Value % 2 == 1)
                {
                    result += c.Value - 1;
                    odd++;
                }
                else
                {
                    result += c.Value;
                }
            }
            if (odd > 0)
            {
                result++;
            }


            //Dictionary<char, int> dict = new Dictionary<char, int>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (dict.TryGetValue(s[i], out var counter))
            //    {
            //        dict[s[i]] += 1;
            //    }
            //    else
            //    {
            //        dict.Add(s[i], 1);
            //    }
            //}
            //var result = 0;
            //var orderedDict = dict.OrderByDescending(x => x.Value).ToList();
            //bool isSingle = false;
            //foreach (var ord in orderedDict)
            //{
            //    if (ord.Value == 1)
            //    {
            //        if (!isSingle)
            //        {
            //            result += 1;
            //        }
            //        break;
            //    }
            //    if (ord.Value % 2 == 0)
            //    {
            //        result += ord.Value;

            //    }
            //    else
            //    {
            //        result += ord.Value - 1;
            //        if (!isSingle)
            //        {
            //            isSingle = true;
            //            result += 1;
            //        }
            //    }
            //}

            return result;
        }
    }
}
