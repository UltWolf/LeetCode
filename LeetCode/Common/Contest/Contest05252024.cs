namespace LeetCode.Common.Contest
{
    public class Contest05252024
    {

        //public int DuplicateNumbersXOR(int[] nums)
        //{
        //    Dictionary<int, int> count = new Dictionary<int, int>();


        //    foreach (int num in nums)
        //    {
        //        if (count.ContainsKey(num))
        //        {
        //            count[num]++;
        //        }
        //        else
        //        {
        //            count[num] = 1;
        //        }
        //    }

        //    int xorResult = 0;

        //    foreach (var entry in count)
        //    {
        //        if (entry.Value == 2)
        //        {
        //            xorResult ^= entry.Key;
        //        }
        //    }

        //    return xorResult;
        //}

        public IList<bool> GetResults(int[][] queries)
        {
            var results = new List<bool>();

            return results;
        }
        public int DuplicateNumbersXOR(int[] nums)
        {

            List<int> result = new List<int>();
            Array.Sort(nums);
            for (var i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] == nums[i - 1])
                {
                    result.Add(nums[i]);
                }
            }
            if (result.Count > 0)
            {
                var output = result.ElementAt(0);
                for (var i = 1; i < result.Count; i++)
                {
                    output ^= result[i];
                }
                return output;
            }
            else
            {
                return 0;

            }
        }
    }
}
