using LeetCode.Daily;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day20240614Test
    {
        public static IEnumerable TestCase
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2, 2 }).Returns(1);
                yield return new TestCaseData(new int[] { 3, 2, 1, 2, 1, 7 }).Returns(6);
                yield return new TestCaseData(new int[] { 1, 1, 1, 1, 1 }).Returns(10);
            }
        }
        [Test, TestCaseSource(nameof(TestCase))]
        public int TestArraySort(int[] array)
        {
            return new Day20240614().MinIncrementForUnique(array);
        }
    }
}
