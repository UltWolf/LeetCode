namespace LeetCode.Daily.Day05272024
{


    //    yield return new TestCaseData(
    //                    new int[] { 3, 5 }, 2
    //                    );
    //yield return new TestCaseData(
    //  new int[] { 0, 0 }, -1
    //  );
    //yield return new TestCaseData(
    //    new int[] { 0, 4, 3, 0, 4 }, 3
    //  );
    public class SpecialArray
    {



        public int CalcSpecialArray(int[] nums)
        {
            Array.Sort(nums);
            //if (nums[nums.Length - 1] == 0)
            //{
            //    return -1;
            //}
            int arrayLength = nums.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                var diff = arrayLength - i;
                if (nums[i] >= diff)
                {
                    if (i == 0 || nums[i - 1] < diff)
                    {
                        return diff;
                    }
                }
            }
            return -1;

        }

        //public int CalcSpecialArray(int[] nums)
        //{
        //    Array.Sort(nums,
        //        (item1, item2) =>
        //        {
        //            return item2.CompareTo(item1);
        //        });
        //    int greater = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] == 0)
        //        {
        //            greater = nums.Length - i;
        //            break;
        //        }
        //    }
        //    int result = 0;
        //    if (greater != 0)
        //    {
        //        if (nums[0] == 0)
        //        {
        //            return -1;
        //        }
        //        for (var i = 0; i < nums.Length; i++)
        //        {
        //            if (nums[i] >= greater)
        //            {
        //                result++;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //        return result;
        //    }
        //    else
        //    {
        //        return nums.Length;
        //    }

        //}
    }
}
