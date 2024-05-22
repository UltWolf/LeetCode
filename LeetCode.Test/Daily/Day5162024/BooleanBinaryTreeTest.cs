using LeetCode.Common.Classes;
using LeetCode.Daily.Day5162024;
using System.Collections;

namespace LeetCode.Test.Daily.Day05162024
{
    public class BooleanBinaryTreeTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new TreeNode() { val = 2, left = new TreeNode() { val = 1 }, right = new TreeNode() { val = 3, left = new TreeNode() { val = 0 }, right = new TreeNode() { val = 1 } } });
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestBinaryTree(TreeNode treeNode, bool expectedResult)
        {
            Assert.AreEqual(new BooleanBinaryTree().EvaluateTree(treeNode), expectedResult);
        }
    }

}
