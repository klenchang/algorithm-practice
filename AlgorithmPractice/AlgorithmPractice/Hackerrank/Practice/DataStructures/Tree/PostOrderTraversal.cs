using System;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Tree
{
    public class PostOrderTraversal
    {
        /*
         1
          \
           2
            \
             5
            /  \
           3    6
            \
             4

        expected output = 4 3 6 5 2 1 
         */

        public static void Print(Node root)
        {
            if (root == null) return;
            if (root.left != null) Print(root.left);
            if (root.right != null) Print(root.right);

            Console.Write(root.data + " ");
        }
    }
}
