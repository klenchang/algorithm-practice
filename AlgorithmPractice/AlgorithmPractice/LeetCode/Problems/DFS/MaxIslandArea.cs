using System;

namespace AlgorithmPractice.LeetCode.Problems.DFS
{
    public class MaxIslandArea
    {
        #region topic
        /*
        给定一个包含了一些 0 和 1 的非空二维数组 grid，一个岛屿是一组相邻的 1（代表陆地），
        这里的「相邻」要求两个 1 必须在水平或者竖直方向上相邻。
        你可以假设 grid 的四个边缘都被 0（代表海洋）包围着。
        找到给定的二维数组中最大的岛屿面积。如果没有岛屿，则返回面积为 0 。 

         */
        #endregion

        public static int MaxAreaOfIsland(int[][] grid)
        {
            int res = 0;
            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {
                    if (grid[r][c] == 1)
                    {
                        int a = Area(grid, r, c);
                        res = Math.Max(res, a);
                    }
                }
            }
            return res;
        }

        static int Area(int[][] grid, int r, int c)
        {
            if (!InArea(grid, r, c))
            {
                return 0;
            }
            if (grid[r][c] != 1)
            {
                return 0;
            }
            grid[r][c] = 2;

            return 1
                + Area(grid, r - 1, c)
                + Area(grid, r + 1, c)
                + Area(grid, r, c - 1)
                + Area(grid, r, c + 1);
        }

        static bool InArea(int[][] grid, int r, int c)
        {
            return 0 <= r && r < grid.Length
                 && 0 <= c && c < grid[0].Length;
        }
    }
}
