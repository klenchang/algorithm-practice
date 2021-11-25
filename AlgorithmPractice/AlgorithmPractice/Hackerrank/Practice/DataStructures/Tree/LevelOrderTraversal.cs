using System;
using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Tree
{
    public class LevelOrderTraversal
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
        
        expected output = 1 2 5 3 6 4
         */
        public static void Print(Node root)
        {
            if (root == null) return;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();
                Console.Write(node.data + " ");
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
        }
    }
}
