namespace LeetCode.Daily.Day592024
{
    public class ChildHappiness
    {
        public long MaximumHappinessSum(int[] happiness, int k)
        {
            Array.Sort(happiness);
            long result = 0;
            long diff = 0;
            for (var i = 0; i < happiness.Length && k != 0; i++, k--, diff++)
            {
                var addValue = happiness[i] - diff;
                if (addValue < 0)
                {
                    addValue = 0;
                }

                result += addValue;

            }
            return result;
        }
    }
}
