namespace LeetCode.Daily.Day5202024
{
    public class SubsetXor
    {
        public int SubsetXORSum(int[] nums)
        {
            return subsetXorSum(nums, 0, 0);
        }
        public int subsetXorSum(int[] nums, int index, int currentXOR)
        {
            if (index == nums.Length) return currentXOR;

            int withElement = subsetXorSum(nums, index + 1, currentXOR ^ nums[index]);

            int withoutElement = subsetXorSum(nums, index + 1, currentXOR);

            return withElement + withoutElement;
        }
    }
}
