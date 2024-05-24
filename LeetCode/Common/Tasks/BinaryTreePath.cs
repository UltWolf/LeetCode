using LeetCode.Common.Classes;

namespace LeetCode.Common.Tasks
{
    public class BinaryTreePath
    {
        List<string> path = new List<string>();
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            BinaryTree(root, root.val.ToString());
            return path;
        }
        public void BinaryTree(TreeNode root, string result)
        {
            if (root.left == null && root.right == null)
            {
                path.Add(result);
                return;
            }
            if (root.left != null)
            {
                BinaryTree(root.left, result + "->" + root.left.val);
            }
            if (root.right != null)
            {
                BinaryTree(root.right, result + "->" + root.right.val);
            }
        }
    }
}
