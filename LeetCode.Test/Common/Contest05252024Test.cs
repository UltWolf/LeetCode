using LeetCode.Common.Contest;
using System.Collections;

namespace LeetCode.Test.Common
{
    public class Contest05252024Test
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2, 1, 3 }, 1);
                yield return new TestCaseData(new int[] { 1, 2, 3 }, 0);
                yield return new TestCaseData(new int[] { 1, 2, 2, 1 }, 3);
                yield return new TestCaseData(new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5 }, 5);
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TesContaining(int[] nums, int expectedResult)
        {
            Assert.AreEqual(new Contest05252024().DuplicateNumbersXOR(nums), expectedResult);
        }
    }
}
