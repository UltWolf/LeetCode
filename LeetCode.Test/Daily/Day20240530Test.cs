using LeetCode.Daily;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day20240530Test
    {
        //        Example 1:

        //Input: arr = [2,3,1,6,7]
        //        Output: 4
        //Explanation: The triplets are(0,1,2), (0,2,2), (2,3,4) and(2,4,4)
        //Example 2:

        //Input: arr = [1,1,1,1,1]
        //        Output: 10
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new int[] { 2, 3, 1, 6, 7 }
                    ).Returns(4);
                yield return new TestCaseData(
                  new int[] { 1, 1, 1, 1, 1 }
                  ).Returns(10);
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public int TestRanked(int[] n)
        {
            return new Day20240530().CountTriplets(n);
        }

    }
}
