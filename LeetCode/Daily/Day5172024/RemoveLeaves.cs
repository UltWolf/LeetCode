using LeetCode.Common.Classes;

namespace LeetCode.Daily.Day5172024
{
    public class RemoveLeaves
    {
        public TreeNode RemoveLeafNodes(TreeNode root, int target)
        {

            return Bfs(root, target);
        }
        public TreeNode Bfs(TreeNode root, int target)
        {
            if (root.left != null)
            {
                Bfs(root.left, target);
                if (root.left.val == target && root.left.left == null && root.left.right == null)
                {
                    root.left = null;
                }
            }
            if (root.right != null)
            {
                Bfs(root.right, target);
                if (root.right.val == target && root.right.left == null && root.right.right == null)
                {
                    root.right = null;
                }
            }
            if (root.val == target && root.right == null && root.left == null)
            {
                return null;
            }

            return root;
        }
    }
}
