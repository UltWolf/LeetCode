using LeetCode.Common.Tasks;
using System.Collections;

namespace LeetCode.Test.Common
{
    public class GenerateParenthesesTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                    3,
                    new List<string>() { "((()))", "(()())", "(())()", "()(())", "()()()" });
                yield return new TestCaseData(
                1,
                new List<string>() { "()" });
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestBoats(int numberParentheses, IList<string> expectedResult)
        {
            Assert.AreEqual(expectedResult, new GenerateParentheses().GenerateParenthesis(numberParentheses));
        }
    }
}
