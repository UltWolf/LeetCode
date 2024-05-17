using LeetCode.Common.Classes;
using LeetCode.Daily.Day5172024;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day5172024
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return
                    new TestCaseData(
                        new TreeNode() { val = 1, left = new TreeNode() { val = 2, left = new TreeNode() { val = 2 } }, right = new TreeNode() { val = 3, left = new TreeNode() { val = 2 }, right = new TreeNode() { val = 4 } } },
                        2,
                        new TreeNode() { val = 1, left = null, right = new TreeNode() { val = 3, left = null, right = new TreeNode() { val = 4 } } }

                    );
                yield return
                   new TestCaseData(
                       new TreeNode() { val = 1, left = new TreeNode() { val = 1, }, right = new TreeNode() { val = 1 } },
                       1,
                       null

                   );
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestRemoveLeaves(TreeNode treeNode, int target, TreeNode expectedResult)
        {
            var result = new RemoveLeaves().RemoveLeafNodes(treeNode, target);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
