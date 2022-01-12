using System;

namespace AlgorithmPractice.Hackerrank.Practice.DataStructures.Tree
{
    public class HuffmanDecoding
    {
        /*
         s="1001011"
         Tree is 
              5
            0/ \1
            2  A,3
          0/ \1
         B,1 C,1

         result = ABACA
         Explain: s = 1 + 00 + 1 + 01 + 1
                    = A + B  + A + C  + A
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
        public static string Decode(string s, DecodingNode root)
        {
            if (root == null) 
                return null;
            
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
            return result;
        }
    }
}
