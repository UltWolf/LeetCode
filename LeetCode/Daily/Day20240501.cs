namespace LeetCode.Daily
{
    public class Day20240501
    {
        public string ReversePrefix(string word, char ch)
        {
            char[] wordArray = word.ToCharArray();
            int? index = null;
            for (var i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i] == ch)
                {
                    index = i;
                    break;
                }
            }
            if (index == null)
            {
                return word;
            }
            var mid = index.Value / 2;
            for (var i = 0; i <= mid; i++, index--)
            {
                char acc = wordArray[i];
                wordArray[i] = wordArray[index.Value];
                wordArray[index.Value] = acc;
            }
            return new string(wordArray);

        }
    }
}
