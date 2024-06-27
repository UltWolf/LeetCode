using LeetCode.Common.Classes;
using LeetCode.Common.Tasks;
using System.Collections;

namespace LeetCode.Test.Common
{
    public class _2AddTwoNumbersTest
    {

        //        Input: l1 = [2,4,3], l2 = [5,6,4]
        //        Output: [7,0,8]
        //        Explanation: 342 + 465 = 807.
        //Example 2:

        //Input: l1 = [0], l2 = [0]
        //        Output: [0]
        //        Example 3:

        //Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
        //        Output: [8,9,9,9,0,0,0,1]
        public static IEnumerable GetTest
        {
            get
            {
                yield return new TestCaseData(
                    new ListNode() { val = 2, next = new ListNode() { val = 4, next = new ListNode() { val = 3 } } },
                    new ListNode() { val = 5, next = new ListNode() { val = 6, next = new ListNode() { val = 4 } } }
                    ).Returns(
                    new ListNode() { val = 7, next = new ListNode() { val = 0, next = new ListNode() { val = 8 } } }
                    );
            }
        }
        [Test, TestCaseSource(nameof(GetTest))]
        public ListNode GetListNode(ListNode node, ListNode node2)
        {
            return new _2AddTwoNumbers().AddTwoNumbers(node, node2);
        }

    }
}
