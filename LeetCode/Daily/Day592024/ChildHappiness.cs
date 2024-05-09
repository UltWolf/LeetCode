namespace LeetCode.Daily.Day592024
{
    public class ChildHappiness
    {
        public long MaximumHappinessSum(int[] happiness, int k)
        {
            Array.Sort(happiness, new Comparison<int>((prev, actual) => prev > actual ? -1 : 1));
            long result = 0;
            long diff = 0;
            for (var i = 0; i < happiness.Length && k != 0; i++, k--, diff++)
            {
                var addValue = happiness[i] - diff;
                result += addValue > 0 ? addValue : 0;

            }
            return result;
        }


        //the best??
        //public long MaximumHappinessSum(int[] happiness, int k)
        //{
        //    Array.Sort(happiness);
        //    int i = 0;
        //    long result = 0, lastIndex = happiness.Length - 1;
        //    while (k != 0)
        //    {
        //        if (i == 0) result += happiness[lastIndex - i];
        //        else
        //        {
        //            result += happiness[lastIndex - i] - i > 0 ? happiness[lastIndex - i] - i : 0;
        //        }
        //        i++;
        //        k--;
        //    }


        //    return result;
        //}

        //my another one
        //public long MaximumHappinessSum(int[] happiness, int k)
        //{
        //    Array.Sort(happiness, new Comparison<int>((x, y) => y.CompareTo(x))); ;
        //    long result = 0;
        //    int i = 0;
        //    while (k != 0)
        //    {
        //        var addValue = happiness[i] - i;
        //        result += addValue > 0 ? addValue : 0;
        //        k--; i++;
        //    }
        //    return result;
        //}
    }
}
