using LeetCode.Daily;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day20240618Test
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 2, 4, 6, 8, 10 }, new int[] { 10, 20, 30, 40, 50 }, new int[] { 4, 5, 6, 7 }).Returns(100);
                yield return new TestCaseData(new int[] { 68, 35, 52, 47, 86 }, new int[] { 67, 17, 1, 81, 3 }, new int[] { 92, 10, 85, 84, 82 }).Returns(324);
            }

        }
        [Test, TestCaseSource(nameof(TestCases))]
        public int Test(int[] dif, int[] worker, int[] workers)
        {
            return new Day20240618().MaxProfitAssignment(dif, worker, workers);
        }
    }
}
