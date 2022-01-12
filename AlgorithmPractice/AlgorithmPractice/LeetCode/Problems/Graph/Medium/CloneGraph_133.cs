using System.Collections.Generic;

namespace AlgorithmPractice.LeetCode.Problems.Graph.Medium
{
    public class CloneGraph_133
    {
        #region topic
        /*
        Given a reference of a node in a connected undirected graph.
        Return a deep copy (clone) of the graph.
        Each node in the graph contains a value (int) and a list (List[Node]) of its neighbors.
        
        class Node {
            public int val;
            public List<Node> neighbors;
        } 

        copy from https://leetcode.com/problems/clone-graph/
         */
        #endregion

        public class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node()
            {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }
        public static Node CloneGraph(Node node)
        {
            if (node == null)
                return node;

            if (node.neighbors == null || node.neighbors.Count == 0)
                return new Node(node.val);

            Dictionary<Node, Node> map = new Dictionary<Node, Node>();
            DFS(node, map);

            foreach (var kv in map)
                foreach (var nbs in kv.Key.neighbors)
                    kv.Value.neighbors.Add(map[nbs]);

            return map[node];
        }
        private static void DFS(Node node, Dictionary<Node, Node> map)
        {
            if (map.ContainsKey(node))
                return;
            map.Add(node, new Node(node.val));
            foreach (var nb in node.neighbors)
                DFS(nb, map);
        }
    }
}
