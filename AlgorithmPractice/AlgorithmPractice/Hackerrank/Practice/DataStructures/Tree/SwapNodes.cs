using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Tree
{
    public class SwapNodes
    {
        public class TreeNodeStruct
        {
            public int left;
            public int right;
        }
        public static List<List<int>> Swap(List<List<int>> indexes, List<int> queries)
        {
            var node = BuildTree(indexes);
            var node2 = ConstuctTree(indexes);
            var result = new List<List<int>>();
            foreach (var q in queries)
            {
                var currentLayer = node[q - 1];
                foreach (var pairs in currentLayer)
                {
                    var temp = pairs.left;
                    pairs.left = pairs.right;
                    pairs.right = temp;
                }
            }

            return indexes;
        }
        public static List<List<TreeNodeStruct>> BuildTree(List<List<int>> indexes)
        {
            var node = new List<List<TreeNodeStruct>>();
            var index = 0;
            var loop = 1;
            while (loop > 0)
            {
                var layer = new List<TreeNodeStruct>();
                var bound = index + loop;
                loop = 0;
                while (index < bound)
                {
                    var left = indexes[index][0];
                    var right = indexes[index][1];
                    if (left > 0) loop++;
                    if (right > 0) loop++;
                    layer.Add(new TreeNodeStruct { left = indexes[index][0], right = indexes[index][1] });
                    index++;
                }
                node.Add(layer);
            }
            return node;
        }

        public static Node ConstuctTree(List<List<int>> indexes)
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
