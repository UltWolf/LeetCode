namespace LeetCode.Common.Tasks
{
    public class NumIdentiacalPair
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var count = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count += 1;
                    }
                }
            }
            return count;
        }
    }
}
