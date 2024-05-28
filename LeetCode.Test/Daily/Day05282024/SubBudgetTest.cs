using LeetCode.Daily.Day05282024;
using System.Collections;

namespace LeetCode.Test.Daily.Day05282024
{
    public class SubBudgetTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("abcd", "bcdf", 3).Returns(3);
                yield return new TestCaseData("abcd", "cdef", 3).Returns(1);
                yield return new TestCaseData("abcd", "acde", 0).Returns(1);
                yield return new TestCaseData("abcd", "cdef", 1).Returns(0);
                yield return new TestCaseData("pxezla", "loewbi", 25).Returns(4);
                yield return new TestCaseData("krrgw", "zjxss", 19).Returns(2);
                yield return new TestCaseData("abcd", "abcd", 10).Returns(4);
                yield return new TestCaseData("abcdef", "azcdef", 1).Returns(1);
                yield return new TestCaseData("xyz", "abc", 10).Returns(0);
                yield return new TestCaseData("kpm", "kpn", 1).Returns(2);
                yield return new TestCaseData("abcdxyz", "abcfxyz", 2).Returns(4);
                yield return new TestCaseData("wxyz", "xyzw", 100).Returns(4);
                yield return new TestCaseData("aaaaaaaa", "bbbbbbbb", 8).Returns(4);
            }
        }

        [Test, TestCaseSource(nameof(TestCases))]
        public int TestEqualSubstring(string s, string t, int maxCost)
        {
            return new SubBudget().EqualSubstring(s, t, maxCost);
        }
    }
}
