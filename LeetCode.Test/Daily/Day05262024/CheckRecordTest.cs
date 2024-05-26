using LeetCode.Daily;
using System.Collections;

namespace LeetCode.Test.Daily.Day05262024
{
    public class CheckRecordTest
    {

        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                    2, 8
                    );
                yield return new TestCaseData(
                  1, 3
                  );
                yield return new TestCaseData(
                 10101, 183236316
                 );
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestRanked(int n, long expectedResult)
        {
            Assert.AreEqual(new StudentAttendanceRecord2().CheckRecord(n), expectedResult);
        }
    }
}
