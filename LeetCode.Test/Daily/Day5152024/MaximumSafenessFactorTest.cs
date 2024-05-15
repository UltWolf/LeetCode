using LeetCode.Daily.Day5152024;
using System.Collections;

namespace LeetCode.Test.Daily.Day5152024
{
    public class MaximumSafenessFactorTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new List<List<int>> { new List<int>() { 1, 0, 0 }, new List<int>() { 0, 0, 0 }, new List<int>() { 0, 0, 1 } }, 0);
                yield return new TestCaseData(new List<List<int>> { new List<int>() { 0, 0, 1 }, new List<int>() { 0, 0, 0 }, new List<int>() { 0, 0, 0 } }, 2);
                yield return new TestCaseData(new List<List<int>> { new List<int>() { 0, 0, 0, 1 }, new List<int>() { 0, 0, 0, 0 }, new List<int>() { 1, 0, 0, 0 } }, 2);
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestMaximumSafenessFactor(List<List<int>> input, int expectedResult)
        {
            Assert.AreEqual(new MaximumSafenessFactor().MaximumSafenessFactors(input), expectedResult);
        }
    }
}
