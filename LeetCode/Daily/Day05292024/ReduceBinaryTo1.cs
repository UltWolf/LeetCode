namespace LeetCode.Daily.Day05292024
{
    public class ReduceBinaryTo1
    { //var number = Convert.ToInt64(s, 2);
      //var result = 0;
      //while (number > 1)
      //{
      //    if (number % 2 == 0)
      //    {
      //        number /= 2;
      //    }
      //    else
      //    {
      //        number++;
      //    }
      //    result++;
      //}
      //return result;
        public int NumSteps(string s)
        {
            var result = 0;
            while (s != "1")
            {


                if (s[s.Length - 1] == '0')
                {
                    s = BinaryDivideBy2(s);
                }
                else
                {
                    s = SumBinary(s.ToCharArray());
                }
                result++;
            }
            return result;
        }
        //110 = 011
        //010 = 001
        //100 = 010
        public string BinaryDivideBy2(string s)
        {
            return s.Substring(0, s.Length - 1);
        }
        //011 = 100
        //001 = 010
        //101 = 110

        public string SumBinary(char[] s)
        {
            int accumulate = 1;
            s[s.Length - 1] = '0';
            for (var i = s.Length - 2; i >= 0 && accumulate >= 1; i--)
            {
                accumulate--;
                if (s[i] == '0')
                {
                    s[i] = '1';
                }
                else
                {
                    s[i] = '0';
                    accumulate++;
                }
            }
            var result = new string(s);
            if (result[0] == '0')
            {
                result = '1' + result;
            }
            return result;
        }
    }
}
