namespace LeetCode.Daily
{
    public class Day20240614
    {
        public int MinIncrementForUnique(int[] nums)
        {
            Array.Sort(nums);
            int result = 0;
            int previos = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                var curr = nums[i];
                if (curr > previos)
                {
                    previos = curr;
                    continue;
                }
                var diff = (curr - previos) * (-1) + 1;
                if (diff > 0)
                {
                    curr += diff;
                    result += diff;
                }
                //while (curr <= previos)
                //{
                //    curr += 1;
                //    result++;
                //}
                nums[i] = curr;
                previos = curr;
            }
            return result;
        }
    }
}
