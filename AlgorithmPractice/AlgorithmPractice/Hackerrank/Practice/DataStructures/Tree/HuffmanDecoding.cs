using System;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Tree
{
    public class HuffmanDecoding
    {
        /*
         s="1001011"
         node = 
         */

        public class DecodingNode
        {
            public DecodingNode(string data)
            {
                this.data = data;
            }
            public string data;
            public DecodingNode left;
            public DecodingNode right;
        }
        public static void Decode(string s, DecodingNode root)
        {
            if (root == null) return;
            string result = "";
            DecodingNode temp = root;

            foreach (char c in s)
            {
                temp = c == '0' ? temp.left : temp.right;
                if (temp.left == null && temp.right == null)
                {
                    result += temp.data;
                    temp = root;
                }
            }
            Console.WriteLine(result);
        }
    }
}
