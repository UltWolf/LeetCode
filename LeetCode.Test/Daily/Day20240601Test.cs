using LeetCode.Daily;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day20240601Test
    {
        public static IEnumerable TestCase
        {
            get
            {
                yield return new TestCaseData(new char[] { 'h', 'e', 'l', 'l', 'o' }).Returns(new char[] { 'o', 'l', 'l', 'e', 'h' });
                yield return new TestCaseData(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }).Returns(new char[] { 'h', 'a', 'n', 'n', 'a', 'H' });
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCase))]
        public char[] TestReverseChar(char[] n)
        {
            new Day20240601().ReverseString(n);
            return n;
        }
    }
}
