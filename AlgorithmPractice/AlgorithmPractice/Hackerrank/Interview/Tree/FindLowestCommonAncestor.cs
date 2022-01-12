using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.Hackerrank.Interview.Tree
{
    public class FindLowestCommonAncestor
    {
        #region topic
        /*
         give a binary search tree.
         find the common ancestor between two node.
         ex.
                 2
                / \
               1   3
                  / \
                 4   5
                      \
                       6
         v1 = 4 , v2 = 6
         return Node 3
         */
        #endregion

        public class Node
        {
            public int Data;
            public Node Left;
            public Node Right;
        }
        public static Node LCA(Node root, int v1, int v2)
        {
            var min = Math.Min(v1, v2);
            var max = Math.Max(v1, v2);
            if (root == null || 
                (root != null && root.Data >= min && root.Data <= max))
                return root;
            
            Node res = null;
            if (min > root.Data && root.Right != null)
                res = LCA(root.Right, min, max);
            if (root.Data > max && root.Left != null)
                res = LCA(root.Left, min, max);

            return res;
        }
    }
}
