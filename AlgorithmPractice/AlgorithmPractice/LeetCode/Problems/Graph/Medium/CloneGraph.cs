using System.Collections.Generic;

namespace AlgorithmPractice.LeetCode.Problems.Graph.Medium
{
    public class CloneGraph
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
        public static Node Clone(Node node)
        {
            var map = new Dictionary<Node, Node>();
            DFS(node, new HashSet<Node>(), map);

            foreach (var kv in map)
            {
                foreach (var nd in kv.Key.neighbors)
                {
                    kv.Value.neighbors.Add(map[nd]);
                }
            }

            return map[node];
        }
        private static void DFS(Node node, HashSet<Node> visited, Dictionary<Node, Node> map)
        {
            if (visited.Contains(node))
                return;
            visited.Add(node);
            map.Add(node, new Node(node.val));
            foreach (var nd in node.neighbors)
                DFS(nd, visited, map);
        }
    }
}
