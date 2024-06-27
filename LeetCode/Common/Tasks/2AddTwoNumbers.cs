using LeetCode.Common.Classes;

namespace LeetCode.Common.Tasks
{
    public class _2AddTwoNumbers
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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            var listNumbers = new List<int>();
            var listNumbers1 = new List<int>();
            while (l1 != null)
            {
                listNumbers.Add(l1.val);
                l1 = l1.next;
            }
            while (l2 != null)
            {
                listNumbers1.Add(l2.val);
                l2 = l2.next;
            }
            List<int> sum = new List<int>();
            var diff = listNumbers1.Count - listNumbers.Count;
            var extraNumber = 0;
            for (var i = 0; i < listNumbers.Count; i++)
            {
                var index = diff + i;

                if (i < diff)
                {
                    sum.Add(listNumbers[i]);
                }
                else
                {
                    var sumOfNumbers = listNumbers[i] + listNumbers1[index] + extraNumber;
                    if (sumOfNumbers > 9)
                    {

                        sumOfNumbers = sumOfNumbers - 10;
                        extraNumber = 1;
                    }
                    else
                    {
                        extraNumber = 0;
                    }
                    sum.Add(sumOfNumbers);
                }
            }
            if (extraNumber != 0)
            {
                sum.Insert(0, extraNumber);
            }

            ListNode prev = null;
            for (var i = sum.Count - 1; i >= 0; i--)
            {
                var listNode = new ListNode();
                listNode.val = sum[i];
                if (prev != null)
                {
                    listNode.next = prev;
                }
                prev = listNode;
            }
            return prev;
        }

    }
}
