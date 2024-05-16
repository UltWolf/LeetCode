using LeetCode.Common.Classes;

namespace LeetCode.Daily.Day5162024
{
    public class BooleanBinaryTree
    {



        public bool EvaluateTree(TreeNode root)
        {
            switch (root.val)
            {
                case 0:
                    return false;
                case 1:
                    return true;
                case 2:
                    return EvaluateTree(root.left) || EvaluateTree(root.right);
                default:
                    return EvaluateTree(root.left) && EvaluateTree(root.right);
            }
        }

        //public bool EvaluateTree(TreeNode root)
        //{
        //    if (root.val == 0)
        //    {
        //        return false;
        //    }
        //    if (root.val == 1)
        //    {
        //        return true;
        //    }

        //    if (root.val == 2)
        //    {
        //        return EvaluateTree(root.left) || EvaluateTree(root.right);
        //    }
        //    else
        //    {
        //        return EvaluateTree(root.left) && EvaluateTree(root.right);
        //    }
        //}

    }
}
