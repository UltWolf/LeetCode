using LeetCode.Common.Classes;

namespace LeetCode.Daily.Day572024
{
    public class DoubleLinkedNumber
    {

        /// <summary>
        /// how it must be
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        //public ListNode DoubleIt(ListNode head)
        //{
        //    ListNode first = new ListNode(0, head), prev = first;
        //    while (head != null)
        //    {
        //        int d = head.val * 2;
        //        if (d >= 10) prev.val++;
        //        head.val = d % 10;
        //        prev = head;
        //        head = head.next;
        //    }
        //    return first.val > 0 ? first : first.next;
        //}



        public ListNode DoubleIt(ListNode head)
        {
            int acc = 0;
            string stringRes = "";
            while (head != null)
            {
                stringRes += head.val;
                head = head.next;
            }
            stringRes = Multiply(stringRes);
            ListNode prev = null;
            for (var i = stringRes.Length - 1; i >= 0; i--)
            {
                var listNode = new ListNode();
                listNode.val = stringRes[i] - '0';
                if (prev != null)
                {
                    listNode.next = prev;
                }
                prev = listNode;
            }
            return prev;
        }
        public string Multiply(string stringNumber)
        {
            string result = "";
            int acc = 0;
            for (var i = stringNumber.Length - 1; i >= 0; i--)
            {
                var accr = (((stringNumber[i] - '0') * 2) + acc).ToString();
                if (accr.Length >= 2)
                {
                    acc = accr[0] - '0';
                    result = accr[1] + result;
                }
                else
                {
                    acc = 0;
                    result = accr + result;
                }
            }
            if (acc != 0)
            {
                result = acc + result;
            }
            return result;

        }

    }
}
