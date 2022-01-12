using System;

namespace AlgorithmPractice.LeetCode.Problems.Graph.Easy
{
    public class MinDepthOfBinaryTree_111
    {
        #region topic
        /*
         give a tree, return minimum depth.
         ex.
                3
               / \
              9   20
                  / \
                 15  7
         return 2;
         
                2
                 \
                  3
                   \
                    4
                     \
                      5
                       \
                        6
         return 5; 
         */
        #endregion

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public static int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 1;
            if (root.left != null && root.right == null)
                return 1 + MinDepth(root.left);
            if (root.right != null && root.left == null)
                return 1 + MinDepth(root.right);

            return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
        }
    }
}
