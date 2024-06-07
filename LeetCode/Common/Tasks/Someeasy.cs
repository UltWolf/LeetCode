using LeetCode.Common.Classes;

namespace LeetCode.Common.Tasks
{
    public class Someeasy
    {
        //public int MaximumWealth(int[][] accounts)
        //{
        //    return accounts.Select(f => f.Sum()).Max();
        //}
        public int MaximumWealth(int[][] accounts)
        {
            var result = 0;
            for (var i = 0; i < accounts.Length; i++)
            {
                result = Math.Max(result, accounts[i].Sum());
            }
            return result;
        }

        public bool CanConstruct(string ransomNote, string magazine)
        {

            //Dictionary<char, int> dict = new Dictionary<char, int>();
            //foreach (var mag in magazine)
            //{
            //    if (dict.TryGetValue(mag, out var result))
            //    {
            //        dict[mag] = result + 1;
            //    }
            //    else
            //    {
            //        dict[mag] = 1;
            //    }
            //}
            //foreach (var n in ransomNote)
            //{
            //    if (dict.TryGetValue(n, out var result))
            //    {
            //        result = result - 1;
            //        if (result == -1)
            //        {
            //            return false;
            //        }
            //        else
            //        {
            //            dict[n] = result;
            //        }
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //return true;



            var dict = magazine.GroupBy(f => f).ToDictionary(k => k.FirstOrDefault(), v => v.Count());
            return ransomNote.GroupBy(f => f).All(f =>
            {
                if (dict.TryGetValue(f.FirstOrDefault(), out int value))
                {
                    return value >= f.Count();
                }
                return false;
            });



        }

        //public ListNode MiddleNode(ListNode head)
        //{
        //    var curr = head;
        //    var index = 0;
        //    while (curr.next != null)
        //    {
        //        curr = curr.next;
        //        index++;
        //    }
        //    var middle = (index / 2);
        //    if (index % 2 == 0)
        //    {
        //        middle -= 1;
        //    }
        //    curr = head;
        //    while (middle >= 0)
        //    {
        //        curr = curr.next;
        //        middle--;
        //    }
        //    return curr;
        //}
        //        Input: l1 = [2,4,3], l2 = [5,6,4]
        //        Output: [7,0,8]
        //        Explanation: 342 + 465 = 807.
        //Example 2:

        //Input: l1 = [0], l2 = [0]
        //        Output: [0]
        //        Example 3:

        //Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
        //        Output: [8,9,9,9,0,0,0,1]
        public ListNode SumOfListNode(ListNode node, ListNode node2)
        {
            List<int> nodeC = new List<int>();
            while (node != null)
            {
                nodeC.Add(node.val);
                node = node.next;
            }

            List<int> node2C = new List<int>();
            while (node2 != null)
            {
                node2C.Add(node2.val);
                node2 = node2.next;
            }


            int extra = 0;
            ListNode prev = null;
            for (var i = nodeC.Count - 1; i >= 0; i--)
            {
                var listNode = new ListNode();
                if (prev != null)
                {
                    listNode.next = prev;
                }
                listNode.val = nodeC[i] + node2C[i] + extra;
                extra = 0;
                if (listNode.val > 9)
                {
                    listNode.val -= 10;
                    extra = 1;
                }
                prev = listNode;
            }
            return prev;
        }
        public ListNode MiddleNode(ListNode head)
        {
            var curr = head;
            if (head.next == null)
            {
                return head;
            }
            var index = -1;
            while (curr.next != null)
            {
                curr = curr.next;
                index++;
            }
            var middle = (index / 2);

            curr = head;
            while (middle >= 0)
            {
                curr = curr.next;
                middle--;
            }
            return curr;
        }
    }
}
