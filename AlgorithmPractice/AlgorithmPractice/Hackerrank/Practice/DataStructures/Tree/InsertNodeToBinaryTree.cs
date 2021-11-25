namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Tree
{
    public class InsertNodeToBinaryTree
    {
        /*
            4
           / \
          2   7
         / \
        1   3

        insert 6.

             4
           /   \
          2     7
         / \   /
        1   3 6
         */

        public static Node Insert(Node root, int data)
        {
            if (root == null) return new Node(data);
            if (root.data >= data)
                root.left = Insert(root.left, data);
            else
                root.right = Insert(root.right, data);
            
            return root;
        }
    }
}
