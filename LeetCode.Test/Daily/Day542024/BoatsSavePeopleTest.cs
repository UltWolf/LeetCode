using LeetCode.Daily.Day542024;
using System.Collections;

namespace LeetCode.Test.Daily.Day542024
{
    public class BoatsSavePeopleTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2 }, 3, 1);
                yield return new TestCaseData(new int[] { 3, 5, 3, 4 }, 5, 4);
                yield return new TestCaseData(new int[] { 2, 4 }, 5, 2);
                yield return new TestCaseData(new int[] { 3, 1, 6, 7, 5 }, 7, 4);
                yield return new TestCaseData(new int[] { 3, 8, 7, 1, 4 }, 9, 3);
                yield return new TestCaseData(new int[] { 8, 2, 3, 6, 2, 6 }, 8, 4);
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestBoats(int[] array, int limit, int expectedResult)
        {
            Assert.AreEqual(new BoatsSavePeople().NumRescueBoats(array, limit), expectedResult);
        }
    }
}
