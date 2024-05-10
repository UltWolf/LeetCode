namespace LeetCode.Daily.Day5102024
{
    public class SmallestPrimeFraction
    {
        public int[] KthSmallestPrimeFraction(int[] arr, int k)
        {

            Dictionary<double, int[]> resultDict = new Dictionary<double, int[]>();
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    resultDict.TryAdd((double)arr[i] / arr[j], new int[] { arr[i], arr[j] });
                }
            }
            return resultDict.OrderBy(f => f.Key)..ToArray()[k - 1].Value;
        }
        //best performance 
        //public int[] getFractionsLessThanMid(int[] arr, int k, int n, double mid)
        //{
        //    double maxLessThanMid = 0.0;
        //    //stores indices (x and y )of max fraction less than mid;
        //    //for storing fractions less than mid ()total)
        //    int x = 0, y = 0, total = 0, j = 1;

        //    //loop throught the arr.Length n
        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        //while fraction is greater than mid increment j
        //        while (j < n && arr[i] > arr[j] * mid)
        //        {
        //            j++;
        //        }
        //        //if j is the same as arr.Length n, break
        //        if (j == n) break;

        //        //j fractions greater than mid, n-j fractions smaller than mid, add fractions smaller than mid to total
        //        total += (n - j);

        //        //get fraction
        //        double fraction = (double)arr[i] / arr[j];

        //        //update variables
        //        if (fraction > maxLessThanMid)
        //        {
        //            maxLessThanMid = fraction;
        //            x = i;
        //            y = j;
        //        }
        //    }
        //    //format and return result
        //    return new int[] { total, x, y };
        //}

        //public int[] KthSmallestPrimeFraction(int[] arr, int k)
        //{
        //    int n = arr.Length;
        //    double low = 0, high = 1;

        //    while (low < high)
        //    {
        //        //get mid index
        //        double mid = low + (high - low) / 2;
        //        //passs arr, k, arr.Length, mid index into the method getFractionsLessThanMid
        //        int[] res = getFractionsLessThanMid(arr, k, n, mid);

        //        //if contion met, format and return result
        //        //else if res[0] is less than k, set high to mid 
        //        //else set low to mid
        //        if (res[0] == k) return new int[] { arr[res[1]], arr[res[2]] };
        //        else if (res[0] > k) high = mid;
        //        else low = mid;
        //    }
        //    return new int[] { };

        //}
    }
}
