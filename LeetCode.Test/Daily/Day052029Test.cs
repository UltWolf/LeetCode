using LeetCode.Daily.Day05292024;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day052029Test
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("1101").Returns(6);
                yield return new TestCaseData("10").Returns(1);
                yield return new TestCaseData("1").Returns(0);
            }
        }

        [Test, TestCaseSource(nameof(TestCases))]
        public int TestEqualSubstring(string s)
        {
            return new ReduceBinaryTo1().NumSteps(s);
        }
    }
}
