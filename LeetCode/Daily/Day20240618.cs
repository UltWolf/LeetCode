namespace LeetCode.Daily
{
    public class Day20240618
    {
        //public class ProfitDif
        //{
        //    public int difficulty;
        //    public int profit;

        //}
        //public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
        //{
        //    ProfitDif[] work = new ProfitDif[difficulty.Length];
        //    for (var i = 0; i < difficulty.Length; i++)
        //    {
        //        work[i] = new ProfitDif() { difficulty = difficulty[i], profit = profit[i] };
        //    }
        //    var maxValue = 0;
        //    Array.Sort(work, (item1, item2) => { return item1.difficulty.CompareTo(item2.difficulty); });
        //    for (var i = 0; i < worker.Length; i++)
        //    {
        //        var prof = 0;
        //        for (var j = 0; j < work.Length; j++)
        //        {
        //            if (work[j].difficulty > worker[i])
        //            {
        //                break;
        //            }
        //            else if (work[j].profit > prof)
        //            {
        //                prof = work[j].profit;
        //            }
        //        }
        //        maxValue += prof;
        //    }
        //    return maxValue;
        //}

        //public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
        //{
        //    Array.Sort(difficulty, profit);  
        //    int maxValue = 0;
        //    for (var i = 0; i < worker.Length; i++)
        //    {
        //        var prof = 0;
        //        for (var j = 0; j < difficulty.Length; j++)
        //        {
        //            if (difficulty[j] > worker[i])
        //            {
        //                break;
        //            }
        //            else if (profit[j] > prof)
        //            {
        //                prof = profit[j];
        //            }
        //        }
        //        maxValue += prof;
        //    }
        //    return maxValue;
        //}
        public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
        {
            Array.Sort(difficulty, profit);
            Array.Sort(worker);
            int maxValue = 0;
            int i = 0;
            int j = 0;
            var prof = 0;
            while (i < worker.Length)
            {

                if (j < difficulty.Length && worker[i] >= difficulty[j])
                {
                    prof = Math.Max(prof, profit[j]);
                    j++;
                }
                else
                {
                    i++;
                    maxValue += prof;
                }

            }

            return maxValue;
        }
    }
}
