using LeetCode.Daily;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day20240610Test
    {
        public static IEnumerable TestCase
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 1, 4, 2, 1, 3 })
                .Returns(3);

            }
        }
        [Test, TestCaseSource(nameof(TestCase))]
        public int CalculateString(int[] arr)
        {
            return new Day20240610().HeightChecker(arr);
        }
    }
}
