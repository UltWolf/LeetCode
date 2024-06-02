using System.Text;

namespace LeetCode.Common.Tasks
{
    public class LongestCommonPrefixWrapper
    {
        public string LongestCommonPrefix(string[] strs)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Array.Sort(strs, (str1, str2) =>
            {

                if (str1.Length == str2.Length)
                {
                    return 0;
                }
                return str1.Length <= str2.Length ? -1 : 1;
            });
            var length = strs[0].Length;
            var strLength = strs.Length - 1;
            for (var j = 0; j < length; j++)
            {
                var isEqual = true;
                for (var i = 0; i < strLength; i++)
                {

                    if (strs[i][j] != strs[i + 1][j])
                    {
                        isEqual = false;
                    }
                }
                if (isEqual)
                {
                    stringBuilder.Append(strs[0][j]);
                }
                else
                {
                    break;
                }
            }
            return stringBuilder.ToString();
        }
    }
}
