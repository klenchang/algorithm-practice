using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.Hackerrank.Interview.DictionariesAndHashmaps
{
    public class SherlockandAnagrams
    {
        #region topic
        /*
        Two strings are anagrams of each other if the letters of one string can be 
        rearranged to form the other string. 
        Given a string, find the number of pairs of substrings of the string that are 
        anagrams of each other. 

        Example.
        s = "mom" => [m,m], [mo,om] => 2
        s = "abba" => [a,a], [b,b], [ab,ba], [abb,bba] => 4
        s = "ifailuhkqq" => [i,i], [q,q], [ifa, fai] => 3
        s = "kkkk" => [k,k] * 6, [kk,kk] * 3, [kkk,kkk] => 10
        s = "cdcd" => [c,c], [d,d], [cd,cd], [cd,dc], [dc,cd] => 5

        Constraints
        1 <= q <= 10
        2 <= s.length <= 100
         */
        #endregion

        // refer to https://ithelp.ithome.com.tw/articles/10226340
        // idea: collect all possible combination way.
        // when it happen over twice, count it.
        // a better may refer to https://python5566.wordpress.com/2018/11/23/hackerrank-sherlock-and-anagrams/comment-page-1/
        public static int Solution(string s)
        {
            var wordBook = new Dictionary<string, int>();
            var result = 0;
            //開始檢測所有的字元
            for (var i = 0; i < s.Length; i++)
            {
                //目前檢測到的字元到最後
                for (var j = i; j < s.Length; j++)
                {
                    //先把目前字串切割成趁列排序好後再組成字串
                    var sortString = string.Join("", s.Substring(i, j - i + 1)
                                      .ToCharArray()
                                      .OrderBy(c => c));
                    //創建或計數這個組合
                    if (wordBook.ContainsKey(sortString))
                        wordBook[sortString]++;
                    else
                        wordBook.Add(sortString, 1);
                    // 依照題目要求，這個字母出現兩次以上才計數
                    if (wordBook[sortString] > 1)
                    {
                        result += wordBook[sortString] - 1;
                    }
                }
            }
            return result;
        }
    }
}
