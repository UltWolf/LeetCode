namespace LeetCode.Daily
{
    public class StudentAttendanceRecord2
    {
        public string Letters = "ALP";
        public int varientions = 0;
        public int modulo = 1000000007;

        public int CheckRecord(int n)
        {
            int ans = 0;

            long[,,] dp = new long[2, 3, n + 1];
            dp[0, 0, 1] = 1;
            dp[0, 1, 1] = 1;
            dp[1, 0, 1] = 1;
            for (int i = 1; i < n; i++)
            {
                dp[0, 0, i + 1] = (dp[0, 0, i] + dp[0, 1, i] + dp[0, 2, i]) % modulo;
                dp[0, 1, i + 1] = dp[0, 0, i];
                dp[0, 2, i + 1] = dp[0, 1, i];

                dp[1, 0, i + 1] = (dp[1, 0, i] + dp[1, 1, i] + dp[1, 2, i] +
                                dp[0, 0, i] + dp[0, 1, i] + dp[0, 2, i]) % modulo;

                dp[1, 1, i + 1] = dp[1, 0, i];
                dp[1, 2, i + 1] = dp[1, 1, i];
            }

            ans = (int)((dp[0, 0, n] + dp[0, 1, n] + dp[0, 2, n] + dp[1, 0, n] + dp[1, 1, n] + dp[1, 2, n]) % modulo);
            return ans;
        }

        //public int CheckRecord(int n)
        //{
        //    CreateRecord("", 0, n, 0);
        //    //return varientionsList.Count;
        //    return varientions;
        //}
        //public void CreateRecord(string result, int a_count, int n, int l_count)
        //{
        //    if (result.Length == n)
        //    {
        //        varientions++;
        //        //varientionsList.Add(result);
        //        return;
        //    }
        //    foreach (var s in Letters)
        //    {
        //        if (s == 'L')
        //        {

        //            if (result.Length > 2 && l_count == 2)
        //            {
        //                continue;
        //            }
        //            else
        //            {
        //                CreateRecord(result + s, a_count, n, l_count + 1);
        //            }

        //        }
        //        else if (s == 'A')
        //        {
        //            if (a_count == 1)
        //            {
        //                continue;
        //            }
        //            else
        //            {
        //                CreateRecord(result + s, a_count + 1, n, 0);
        //            }
        //        }
        //        else
        //        {
        //            CreateRecord(result + s, a_count, n, 0);
        //        }

        //    }
        //}
    }
}
