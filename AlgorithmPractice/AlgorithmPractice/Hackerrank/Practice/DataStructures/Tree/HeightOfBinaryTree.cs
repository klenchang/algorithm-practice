using System;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Tree
{
    public class HeightOfBinaryTree
    {
        /*
            4
           / \
          2   6
         / | | \
        1  3 5  7

        expected output = 2
         */

        public static int Height(Node root)
        {
            if (root == null) return 0;
            var leftHeight = 0;
            if (root.left != null) leftHeight = 1 + Height(root.left);
            var rightHeight = 0;
            if (root.right != null) rightHeight = 1 + Height(root.right);

            return Math.Max(leftHeight, rightHeight);
        }
    }
}
