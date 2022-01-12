namespace AlgorithmPractice.LeetCode.Problems.DFS
{
    public class MaxIslandArea_695
    {
        #region topic
        /*
        给定一个包含了一些 0 和 1 的非空二维数组 grid，一个岛屿是一组相邻的 1（代表陆地），
        这里的「相邻」要求两个 1 必须在水平或者竖直方向上相邻。
        你可以假设 grid 的四个边缘都被 0（代表海洋）包围着。
        找到给定的二维数组中最大的岛屿面积。如果没有岛屿，则返回面积为 0 。 

        copy@right: https://leetcode.com/problems/max-area-of-island/
         */
        #endregion

        public static int MaxAreaOfIsland(int[][] grid)
        {
            var res = 0;
            for (int x = 0; x < grid.Length; x++)
                for (int y = 0; y < grid[0].Length; y++)
                    if (grid[x][y] == 1)
                    {
                        var size = GetAreaSize(grid, x, y);
                        if (res < size)
                            res = size;
                    }
            return res;
        }
        private static int GetAreaSize(int[][] grid, int x, int y)
        {
            if (!InArea(grid, x, y) || grid[x][y] != 1)
                return 0;
            grid[x][y] = 2;

            return 1
                + GetAreaSize(grid, x - 1, y)
                + GetAreaSize(grid, x + 1, y)
                + GetAreaSize(grid, x, y - 1)
                + GetAreaSize(grid, x, y + 1);
        }
        private static bool InArea(int[][] grid, int x, int y)
        {
            return 0 <= x && x < grid.Length && 0 <= y && y < grid[0].Length;
        }
    }
}
