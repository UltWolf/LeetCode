using LeetCode.Common.Classes;
using LeetCode.Common.Tasks;
using System.Collections;

namespace LeetCode.Test.Common
{
    public class SomeeasyTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new ListNode()
                {
                    val = 1,
                    next = new ListNode()
                    {
                        val = 2,
                        next = new ListNode()
                        {
                            val = 3,
                            next = new ListNode()
                            {
                                val = 4,
                                next = new ListNode()
                                {
                                    val = 5,
                                    next = new ListNode()
                                    {
                                        val = 6
                                    }
                                }
                            }
                        }
                    }

                },
                new ListNode()
                {
                    val = 1,
                    next = new ListNode()
                    {
                        val = 2,
                        next = new ListNode()
                        {
                            val = 3,
                            next = new ListNode()
                            {
                                val = 4
                            }
                        }
                    }

                });
            }
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestBoats(ListNode listNode, ListNode expectedResult)
        {
            Assert.AreEqual(expectedResult, new Someeasy().MiddleNode(listNode));
        }
        private static IEnumerable TestCasesMagazine
        {
            get
            {
                yield return new TestCaseData("fihjjjjei", "hjibagacbhadfaefdjaeaebgi", false);
                yield return new TestCaseData("fffbfg", "effjfggbffjdgbjjhhdegh", true);
                yield return new TestCaseData("aa", "aab", true);
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCasesMagazine))]
        public void TestMagazine(string ransomNote, string magazine, bool expectedResult)
        {
            Assert.AreEqual(expectedResult, new Someeasy().CanConstruct(ransomNote, magazine));
        }

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
        private static IEnumerable TestCasesRoman
        {
            get
            {
                yield return new TestCaseData("III").Returns(3);
                yield return new TestCaseData("LVIII").Returns(58);
                yield return new TestCaseData("MCMXCIV").Returns(1994);
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCasesRoman))]
        public int TestRoman(string romanString)
        {
            return new RomanToIntegers().RomanToInt(romanString);
        }
    }
}
