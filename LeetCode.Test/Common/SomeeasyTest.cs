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
        //        Input: l1 = [2,4,3], l2 = [5,6,4]
        //        Output: [7,0,8]
        //        Explanation: 342 + 465 = 807.
        //Example 2:

        //Input: l1 = [0], l2 = [0]
        //        Output: [0]
        //        Example 3:

        //Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
        //        Output: [8,9,9,9,0,0,0,1]
        private static IEnumerable TestCasesSumNodes
        {
            get
            {


                yield return new TestCaseData(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4)))).Returns(new ListNode(7, new ListNode(0, new ListNode(8))));
                yield return new TestCaseData(new ListNode(0), new ListNode(0)).Returns(new ListNode(0));
                yield return new TestCaseData(new ListNode(9,
                                  new ListNode(9,
                                    new ListNode(9,
                                      new ListNode(9,
                                        new ListNode(9,
                                          new ListNode(9,
                                            new ListNode(9))))))),
                                            new ListNode(9,
                                  new ListNode(9,
                                    new ListNode(9,
                                      new ListNode(9))))
                                            ).Returns(new ListNode(8,
                    new ListNode(9,
                      new ListNode(9,
                        new ListNode(9,
                          new ListNode(0,
                            new ListNode(0,
                              new ListNode(0,
                                new ListNode(1)))))))));

            }
        }
        [Test]
        [TestCaseSource(nameof(TestCasesSumNodes))]
        public ListNode TestSum(ListNode l1, ListNode l2)
        {
            return new Someeasy().SumOfListNode(l1, l2);
        }
    }
}
