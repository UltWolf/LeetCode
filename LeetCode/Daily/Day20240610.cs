namespace LeetCode.Daily
{
    public class Day20240610
    {
        public int HeightChecker(int[] heights)
        {
            var length = heights.Length;
            int[] copy = new int[length];
            Array.Copy(heights, copy, length);
            Array.Sort(copy, (item1, item2) => { return item1.CompareTo(item2); });
            int result = 0;
            for (var i = 0; i < length; i++)
            {
                if (copy[i] != heights[i])
                {
                    result++;
                }
            }
            return result;
        }
    }
}
