using LeetCode.Daily;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day20240607Test
    {
        public static IEnumerable TestCase
        {
            get
            {
                yield return new TestCaseData(new List<string>() { "cat", "bat", "rat" }, "the cattle was rattled by the battery")
                .Returns("the cat was rat by the bat");
                yield return new TestCaseData(new List<string>() { "a", "b", "c" }, "aadsfasf absbs bbab cadsfafs")
                .Returns("a a b c");
                yield return new TestCaseData(new List<string>() { "a", "aa", "aaa", "aaaa" }, "a aa a aaaa aaa aaa aaa aaaaaa bbb baba ababa")
             .Returns("a a a a a a a a bbb baba a");
                yield return new TestCaseData(new List<string>() { "catt", "cat", "bat", "rat" }, "the cattle was rattled by the battery")
          .Returns("the cat was rat by the bat");
            }
        }
        [Test, TestCaseSource(nameof(TestCase))]
        public string CalculateString(IList<string> dictionary, string sentence)
        {
            return new Day20240607().ReplaceWords(dictionary, sentence);
        }
    }
}
