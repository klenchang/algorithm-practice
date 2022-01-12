namespace AlgorithmPractice.LeetCode.Problems.DFS
{
    public class CalculateIslandPerimeter_463
    {
        #region topic
        /*
         You are given row x col grid representing a map 
         where grid[i][j] = 1 represents land and grid[i][j] = 0 represents water.

         Grid cells are connected horizontally/vertically (not diagonally). 
         The grid is completely surrounded by water, and there is exactly one island 
         (i.e., one or more connected land cells).

         The island doesn't have "lakes", 
         meaning the water inside isn't connected to the water around the island. 
         One cell is a square with side length 1. 
         The grid is rectangular, width and height don't exceed 100. 
         Determine the perimeter of the island.

         Input: grid = [[0,1,0,0],[1,1,1,0],[0,1,0,0],[1,1,0,0]]
         Output: 16
         Explanation: The perimeter is the 16 yellow stripes in the image above.

         copy@right:https://leetcode.com/problems/island-perimeter/
         */
        #endregion

        public static int IslandPerimeter(int[][] grid)
        {
            for (int x = 0; x < grid.Length; x++)
                for (int y = 0; y < grid[0].Length; y++)
                    if (grid[x][y] == 1)
                        // there is exactly one island, no need to calculate multiple island
                        return GetPerimeterSize(grid, x, y); 
            return 0;
        }
        private static int GetPerimeterSize(int[][] grid, int x, int y)
        {
            if (!InArea(grid, x, y) || grid[x][y] == 0)
                return 1;
            if (grid[x][y] == 2)    //already be calculated before
                return 0;

            grid[x][y] = 2;

            return GetPerimeterSize(grid, x - 1, y)
                 + GetPerimeterSize(grid, x + 1, y)
                 + GetPerimeterSize(grid, x, y - 1)
                 + GetPerimeterSize(grid, x, y + 1);
        }
        private static bool InArea(int[][] grid, int x, int y)
        {
            return 0 <= x && x < grid.Length && 0 <= y && y < grid[0].Length;
        }
    }
}
