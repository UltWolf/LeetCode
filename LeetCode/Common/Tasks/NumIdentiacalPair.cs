namespace LeetCode.Common.Tasks
{
    public class NumIdentiacalPair
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var count = 0;
            var arrayLength = nums.Length;
            for (var i = 0; i < arrayLength; i++)
            {
                for (var j = i + 1; j < arrayLength; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
