namespace LeetCode.Daily.Day5142024
{
    public class MaximumGold
    {
        public int GetMaximumGold(int[][] grid)
        {

            if (grid == null || grid.Length == 0)
                return 0;

            int m = grid.Length, n = grid[0].Length, max = 0; ;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    max = Math.Max(max, Move(grid, i, j, new bool[m, n]));
                }
            }

            return max;
        }

        private int Move(int[][] grid, int i, int j, bool[,] visited)
        {
            int m = grid.Length, n = grid[0].Length;
            if (i < 0 || i >= m || j < 0 || j >= n || visited[i, j] || grid[i][j] == 0)
                return 0;
            visited[i, j] = true;
            int up = Move(grid, i - 1, j, visited);
            int down = Move(grid, i + 1, j, visited);
            int left = Move(grid, i, j - 1, visited);
            int right = Move(grid, i, j + 1, visited);
            int sum = Math.Max(Math.Max(up, down), Math.Max(left, right)) + grid[i][j];
            visited[i, j] = false;
            return sum;
        }
        //public int Move(int[][] grid, int index, int endIndex, int result)
        //{

        //    (int, int)? largeIndex = null;
        //    int acc = 0;
        //    int leftIndex = endIndex - 1;
        //    if (leftIndex >= 0 && grid[index][leftIndex] > acc && !visitedIndexes.Any(f => f.Item1 == index && f.Item2 == leftIndex))
        //    {
        //        acc = grid[index][leftIndex];
        //        largeIndex = new(index, leftIndex);
        //    }
        //    int upperIndex = index - 1;
        //    if (upperIndex >= 0 && grid[upperIndex][endIndex] > acc && !visitedIndexes.Any(f => f.Item1 == upperIndex && f.Item2 == endIndex))
        //    {
        //        acc = grid[upperIndex][endIndex];
        //        largeIndex = new(upperIndex, endIndex);
        //    }
        //    int lowerIndex = index + 1;
        //    if (lowerIndex < grid.Length && grid[lowerIndex][endIndex] > acc && !visitedIndexes.Any(f => f.Item1 == lowerIndex && f.Item2 == endIndex))
        //    {
        //        acc = grid[lowerIndex][endIndex];
        //        largeIndex = new(lowerIndex, endIndex);
        //    }
        //    int rightIndex = endIndex + 1;
        //    if (rightIndex < grid[index].Length && grid[index][rightIndex] > acc && !visitedIndexes.Any(f => f.Item1 == index && f.Item2 == rightIndex))
        //    {
        //        acc = grid[index][rightIndex];
        //        largeIndex = new(index, rightIndex);
        //    }

        //    if (largeIndex != null)
        //    {
        //        result += acc;
        //        visitedIndexes.Add(largeIndex.Value);
        //        return Move(grid, largeIndex.Value.Item1, largeIndex.Value.Item2, result);
        //    }
        //    return result; ;
        //}
    }
}
