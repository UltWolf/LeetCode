using LeetCode.Daily.Day5102024;
using System.Collections;

namespace LeetCode.Test.Daily.Day5102024
{
    public class SmallestPrimeFractionTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new int[] { 1, 2, 3, 5 },
                     3,
                    new int[] { 2, 5 }
                    );
                yield return new TestCaseData(
                   new int[] { 1, 29, 47 },
                    1,
                   new int[] { 1, 47 }
                   );
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestFranction(int[] array, int k, int[] expectedResult)
        {
            Assert.AreEqual(new SmallestPrimeFraction().KthSmallestPrimeFraction(array, k), expectedResult);
        }
    }
}
