namespace LeetCode.Daily
{
    //    for (int i = 0; i < nums.Length; i++)
    //            {
    //                bool isTwice = false;
    //                for (int j = i + 1; j<nums.Length; j++)
    //                {
    //                    if (nums[j] == nums[i])
    //                    {
    //                        isTwice = true;
    //                        break;
    //                    }
    //                }
    //                if (!isTwice)
    //{
    //    numbers.Add(nums[i]);
    //}
    //            }
    //            return numbers.ToArray();
    public class Day20240531
    {
        List<int> numbers = new List<int>();
        public int[] SingleNumber(int[] nums)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                if (!dict.ContainsKey(n)) { dict[n] = 1; }
                else { dict[n]++; }
            }

            foreach (int n in dict.Keys)
            {
                if (dict[n] == 1) { numbers.Add(n); }
            }

            return numbers.ToArray();
            //Array.Sort(nums);
            //for (var i = 0; i < nums.Length;)
            //{
            //    var newIndex = i + 1;
            //    if (newIndex < nums.Length && nums[i] == nums[newIndex])
            //    {
            //        i += 2;
            //    }
            //    else
            //    {
            //        numbers.Add(nums[i]);
            //        i++;
            //    }
            //}
            //return numbers.ToArray();

            //for (var i = 0; i < nums.Length; i++)
            //{
            //    if (numbers.Any(f => f == nums[i]))
            //    {
            //        numbers.Remove(nums[i]);
            //    }
            //    else
            //    {
            //        numbers.Add(nums[i]);
            //    }
            //}
            //return numbers.ToArray();
        }
    }
}
