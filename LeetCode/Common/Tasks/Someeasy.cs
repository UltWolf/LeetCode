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
