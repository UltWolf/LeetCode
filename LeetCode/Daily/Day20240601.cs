namespace LeetCode.Daily
{
    public class Day20240601
    {
        //public void ReverseString(char[] s)
        //{
        //    ReverseStringRec(s, 0);
        //}
        //public void ReverseStringRec(char[] s, int i)
        //{
        //    if (i > s.Length / 2 - 1)
        //        return;
        //    char temp = s[i];
        //    s[i] = s[s.Length - 1 - i];
        //    s[s.Length - 1 - i] = temp;
        //    ReverseStringRec(s, ++i);
        //}
        public void ReverseString(char[] s)
        {

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                left++;
                right--;
            }
            //var length = s.Length;
            //int mid = length / 2;
            //if (length % 2 != 0)
            //{
            //    mid += 1;
            //}
            //var lastIndex = length;
            //for (var i = 0; i < mid; i++)
            //{

            //    var acc = s[i];
            //    lastIndex -= 1;
            //    s[i] = s[lastIndex];
            //    s[lastIndex] = acc;
            //}
        }
    }
}
