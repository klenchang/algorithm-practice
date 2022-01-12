namespace AlgorithmPractice.Hackerrank.Interview.Tree
{
    public class IsABinarySearchTree
    {
        #region topic
        /*
         check if a tree is a BST.
         BST is a tree
         1. left node value < root node value
         2. root node value < right node value
         */
        #endregion
        public class Node
        {
            public int Data;
            public Node Left;
            public Node Right;
        }
        public static bool CheckBST(Node root)
        {
            if (root == null)
                return true;
            else
            {
                if ((root.Left != null && root.Left.Data >= root.Data) ||
                   (root.Right != null && root.Right.Data <= root.Data))
                    return false;
            }

            var res = CheckBST(root.Left);
            if (res)
                res = CheckBST(root.Right);

            return res;
        }
    }
}
