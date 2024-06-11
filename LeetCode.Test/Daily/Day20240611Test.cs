using LeetCode.Daily;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day20240611Test
    {
        public static IEnumerable TestCase
        {
            get
            {
                yield return new TestCaseData(new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, new int[] { 2, 1, 4, 3, 9, 6 }).Returns(new int[] { 2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19 });
            }
        }
        [Test, TestCaseSource(nameof(TestCase))]
        public int[] Sort(int[] arr1, int[] arr2)
        {
            return new Day20240611().RelativeSortArray(arr1, arr2);
        }
    }
}
