using System.Collections.Generic;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Tree
{
    public class SwapNodes
    {
        /*
         A binary tree is a tree which is characterized by one of the following properties:
            It can be empty (null).
            It contains a root node only.
            It contains a root node with a left subtree, a right subtree, or both. These subtrees are also binary trees.
        In-order traversal is performed as
            Traverse the left subtree.
            Visit root.
            Traverse the right subtree.
        For this in-order traversal, 
        start from the left child of the root node and keep exploring the left subtree until you reach a leaf. 
        When you reach a leaf, back up to its parent, check for a right child and visit it if there is one. 
        If there is not a child, you've explored its left and right subtrees fully. 
        If there is a right child, traverse its left subtree then its right in the same manner. 
        Keep doing this until you have traversed the entire tree. 
        You will only store the values of a node as you visit when one of the following is true:
            it is the first node visited, the first time visited
            it is a leaf, should only be visited once
            all of its subtrees have been explored, should only be visited once while this is true
            it is the root of the tree, the first time visited
        Swapping: 
            Swapping subtrees of a node means that if initially node has left subtree L and right subtree R, 
        then after swapping, the left subtree will be R and the right subtree, L.

        For example, in the following tree, we swap children of node 1.
                                         Depth
             1               1            [1]
            / \             / \
           2   3     ->    3   2          [2]
            \   \           \   \
             4   5           5   4        [3]

        In-order traversal of left tree is 2 4 1 3 5 and of right tree is 3 5 1 2 4.

        Constraints
            1 <= n <= 1024
            1 <= t <= 100
            1 <= k <= n
            Either a = -1 or 2 <= a <= n 
            Either b = -1 or 2 <= b <= n
            The index of a non-null child will always be greater than that of its parent.
         */

        public static List<List<int>> Swap(List<List<int>> indexes, List<int> queries)
        {
            var node = ConstuctTree(indexes);
            var result = new List<List<int>>();
            foreach (var q in queries)
                result.Add(Print(node, q, 1, new List<int>()));

            return result;
        }
        static List<int> Print(Node node, int exchangeDepth, int currentDepth, List<int> result)
        {
            if (node == null) return result;
            // swap
            if (currentDepth % exchangeDepth == 0)
            {
                var temp = node.left;
                node.left = node.right;
                node.right = temp;
            }
            if (node.left != null) Print(node.left, exchangeDepth, currentDepth + 1, result);
            result.Add(node.data);
            if (node.right != null) Print(node.right, exchangeDepth, currentDepth + 1, result);

            return result;
        }
        static Node ConstuctTree(List<List<int>> indexes)
        {
            Node root = new Node(1);
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            for (int i = 0; i < indexes.Count; i++)
            {
                Node left, right;
                if (indexes[i][0] != -1)
                    left = new Node(indexes[i][0]);
                else
                    left = null;
                if (indexes[i][1] != -1)
                    right = new Node(indexes[i][1]);
                else
                    right = null;

                Node temp = q.Dequeue();
                temp.left = left;
                temp.right = right;

                if (left != null)
                    q.Enqueue(left);
                if (right != null)
                    q.Enqueue(right);
            }
            return root;
        }
    }
}
