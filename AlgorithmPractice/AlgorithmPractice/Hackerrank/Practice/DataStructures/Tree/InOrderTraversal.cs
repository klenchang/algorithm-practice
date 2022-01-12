using System;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Tree
{
    public class InOrderTraversal
    {
        /*
         1
          \
           2
            \
             5
            / \
           3   6
            \
             4 

        expected output = 1 2 3 4 5 6
         */

        public static void Print(Node root)
        {
            if (root == null) return;
            if (root.left != null) Print(root.left);
            Console.Write(root.data + " ");

            if (root.right != null) Print(root.right);
        }
    }
}
