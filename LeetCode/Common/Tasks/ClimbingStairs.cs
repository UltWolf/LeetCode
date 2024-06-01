namespace LeetCode.Common.Tasks
{
    public class ClimbingStairs
    {
        public int Count = 0;
        public int ClimbStairs(int n)
        {
            Calc(0, n);
            return Count;
        }

        //public int ClimbStairs(int n)
        //{
        //    int[] arr = new int[n + 2];
        //    arr[0] = 0; arr[1] = 1;
        //    for (int i = 2; i < n + 2; i++)
        //    {
        //        arr[i] = arr[i - 1] + arr[i - 2];

        //    }
        //    return arr[n + 1];
        //}
        //not mine
        //public double GOLDEN_RATIO = 1.61803398875;
        //public int ClimbStairs(int n)
        //{
        //    return (int)((Math.Pow(GOLDEN_RATIO, n + 1) - Math.Pow(1 - GOLDEN_RATIO, n + 1)) / (double)(Math.Sqrt(5)));
        //}
        public void Calc(int sum, int n)
        {
            sum += 1;
            if (sum < n)
            {
                Calc(sum, n);
            }
            else if (sum == n)
            {
                Count++;
            }
            sum += 1;
            if (sum < n)
            {
                Calc(sum, n);
            }
            else if (sum == n)
            {
                Count++;
            }
        }

    }
}
