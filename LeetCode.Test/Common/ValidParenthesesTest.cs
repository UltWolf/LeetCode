using LeetCode.Common.Tasks;
using System.Collections;

namespace LeetCode.Test.Common
{
    public class ValidParenthesesTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("()", true);
                yield return new TestCaseData("()[]{}", true);
                yield return new TestCaseData("{[]}", true);
                yield return new TestCaseData("(]", false);
                yield return new TestCaseData("([)]", false);
                yield return new TestCaseData("(){}}{", false);
                yield return new TestCaseData("({{{{}}}))", false);
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestBoats(string input, bool expectedResult)
        {
            Assert.AreEqual(expectedResult, new ValidParentheses().IsValid(input));
        }
    }
}
