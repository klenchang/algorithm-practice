using System;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Tree
{
    public class PreOrderTraversal
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
        
        expected output = 1 2 5 3 4 6
         */

        public static void Print(Node root)
        {
            if (root == null) return;
            Console.Write(root.data + " ");

            if (root.left != null) Print(root.left);

            if (root.right != null) Print(root.right);
        }
    }
}
