using LeetCode.Daily;
using System.Collections;

namespace LeetCode.Test.Daily
{
    //    Input: hand = [1,2,3,6,2,3,4,7,8], groupSize = 3
    //Output: true
    //Explanation: Alice's hand can be rearranged as [1,2,3],[2,3,4],[6,7,8]
    //Example 2:

    //Input: hand = [1,2,3,4,5], groupSize = 4
    //Output: false
    //Explanation: Alice's hand can not be rearranged into groups of 4.
    public class Day20240606Test
    {

        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2, 3, 6, 2, 3, 4, 7, 8 }, 3).Returns(true);
                yield return new TestCaseData(new int[] { 1, 2, 3, 4, 5 }, 4).Returns(false);
                yield return new TestCaseData(new int[] { 8, 10, 12 }, 3).Returns(false);
                yield return new TestCaseData(new int[] { 5, 1 }, 1).Returns(true);
                yield return new TestCaseData(new int[] { 1, 1, 2, 2, 3, 3 }, 2).Returns(false);
            }
        }
        [Test, TestCaseSource(nameof(TestCases))]
        public bool TestGroup(int[] array, int groupSize)
        {
            return new Day20240606().IsItCanGrouped(array, groupSize);
        }
    }
}
