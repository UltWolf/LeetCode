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
    }
}
