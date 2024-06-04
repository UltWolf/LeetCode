namespace LeetCode.Common.Tasks
{
    public class RomanToIntegers
    {
        //        I             1
        //V             5
        //X             10
        //L             50
        //C             100
        //D             500
        //M             1000
        //        Input: s = "III"
        //Output: 3
        //Explanation: III = 3.
        //Example 2:

        //Input: s = "LVIII"
        //Output: 58
        //Explanation: L = 50, V= 5, III = 3.
        //Example 3:

        //Input: s = "MCMXCIV"
        //Output: 1994
        public int RomanToInt(string s)
        {
            int sum = 0;
            int previous = 0;
            for (var i = s.Length - 1; i >= 0; i--)
            {

                var curr = getInt(s[i]);
                if (
                    (curr == 1 && (previous == 5 || previous == 10))
                    ||
                    (curr == 10 && (previous == 50 || previous == 100))
                    ||
                    (curr == 100 && (previous == 500 || previous == 1000))
                    )
                {
                    sum -= curr;
                }
                else
                {
                    sum += curr;
                }

                previous = curr;
            }
            return sum;
        }

        public int getInt(char c)
        {
            switch (c)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;

                case 'M':
                    return 1000;
            }
            return 0;
        }
    }
}
