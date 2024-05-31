using LeetCode.Daily;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day20240531Test
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new int[] { 1, 2, 3, 1, 2, 5 }
                    ).Returns(new int[] { 3, 5 });
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public int[] Test(int[] n)
        {
            return new Day20240531().SingleNumber(n);
        }
    }
}
