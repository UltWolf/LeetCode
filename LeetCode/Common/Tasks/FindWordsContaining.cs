namespace LeetCode.Common.Tasks
{
    public class FindWordsContainingClass
    {

        public IList<int> FindWordsContaining(string[] words, char x)
        {
            return words.Select((word, index) => new { word, index }).Where(f => f.word.Contains(x)).Select(f => f.index).ToList();
        }

        //public IList<int> FindWordsContaining(string[] words, char x)
        //{
        //    List<int> result = new List<int>();
        //    for (var i = 0; i < words.Length; i++)
        //    {
        //        if (words[i].Any(f => f == x))
        //        {
        //            result.Add(i);
        //        }
        //    }
        //    return result;
        //}

        //public IList<int> FindWordsContaining(string[] words, char x)
        //{
        //    List<int> result = new List<int>();
        //    for (var i = 0; i < words.Length; i++)
        //    {
        //        if (words[i].Contains(x))
        //        {
        //            result.Add(i);
        //        }
        //    }
        //    return result;
        //}
    }
}
