using LeetCode.Common.Tasks;
using System.Collections;

namespace LeetCode.Test.Common
{
    public class PalindromeTest
    {
        private static IEnumerable TestCaseInt
        {
            get
            {
                yield return new TestCaseData(11).Returns(true);
                yield return new TestCaseData(121).Returns(true);
                yield return new TestCaseData(12121).Returns(true);
                yield return new TestCaseData(1213421).Returns(false);
                yield return new TestCaseData(12132421).Returns(false);
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCaseInt))]
        public bool IsPalindrome(int n)
        {
            return new Palindrome().IsPalindromeInt(n);
        }

        private static IEnumerable TestCase
        {
            get
            {
                yield return new TestCaseData("A man, a plan, a canal: Panama").Returns(true);
                yield return new TestCaseData("race a car").Returns(false);
                yield return new TestCaseData("").Returns(true);
                yield return new TestCaseData("a.").Returns(true);
                yield return new TestCaseData(".,").Returns(true);
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCase))]
        public bool IsPalindrome(string s)
        {
            return new Palindrome().IsCorrectPalindrome(s);
        }
    }
}
