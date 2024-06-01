using LeetCode.Common.Tasks;
using System.Collections;

namespace LeetCode.Test.Common
{
    public class ClimbingStairsTest
    {
        private static IEnumerable TestCase
        {
            get
            {
                yield return new TestCaseData(2).Returns(2);
                yield return new TestCaseData(3).Returns(3);
                yield return new TestCaseData(9).Returns(9);
                yield return new TestCaseData(10).Returns(10);
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCase))]
        public int TestBoats(int n)
        {
            return new ClimbingStairs().ClimbStairs(n);
        }
    }
}
