using LeetCode.Common.Classes;
using LeetCode.Daily.Day572024;
using System.Collections;

namespace LeetCode.Test.Daily.Day572024
{
    public class DoubleLinkedNumberTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new ListNode() { val = 1, next = new ListNode() { val = 8, next = new ListNode() { val = 9 } } },
                    new ListNode() { val = 3, next = new ListNode() { val = 7, next = new ListNode() { val = 8 } } }
                    );
                yield return new TestCaseData(
                    new ListNode() { val = 9, next = new ListNode() { val = 9, next = new ListNode() { val = 9 } } },
                    new ListNode() { val = 1, next = new ListNode() { val = 9, next = new ListNode() { val = 9, next = new ListNode() { val = 8 } } } }
                    );
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestLinkedNumberDoubleIt(ListNode testCase, ListNode expected)
        {
            Assert.AreEqual(new DoubleLinkedNumber().DoubleIt(testCase).ToString(), expected.ToString());
        }
    }
}
