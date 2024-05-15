namespace LeetCode.Daily.Day5152024
{
    public class MaximumSafenessFactor
    {
        int[][] dir = { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };

        public int MaximumSafenessFactors(List<List<int>> grid)
        {
            int n = grid.Count;
            if (grid[0][0] == 1 || grid[n - 1][n - 1] == 1)
            {
                return 0;
            }
            int[,] mat = new int[n, n];
            Queue<int[]> multiSourceQueue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        multiSourceQueue.Enqueue(new int[] { i, j });
                        mat[i, j] = 0;
                    }
                    else
                    {
                        mat[i, j] = -1;
                    }
                }
            }
            while (multiSourceQueue.Count > 0)
            {
                int size = multiSourceQueue.Count;
                while (size-- > 0)
                {
                    int[] curr = multiSourceQueue.Dequeue();
                    foreach (var d in dir)
                    {
                        int di = curr[0] + d[0];
                        int dj = curr[1] + d[1];
                        int val = mat[curr[0], curr[1]];
                        if (IsValidCell(mat, di, dj) && mat[di, dj] == -1)
                        {
                            mat[di, dj] = val + 1;
                            multiSourceQueue.Enqueue(new int[] { di, dj });
                        }
                    }
                }
            }

            int start = 0;
            int end = 0;
            int res = -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    end = Math.Max(end, mat[i, j]);
                }
            }

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (IsValidSafeness(mat, mid))
                {
                    res = mid;
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return res;
        }

        private bool IsValidSafeness(int[,] grid, int minSafeness)
        {
            int n = grid.GetLength(0);

            if (grid[0, 0] < minSafeness || grid[n - 1, n - 1] < minSafeness)
            {
                return false;
            }

            Queue<int[]> traversalQueue = new Queue<int[]>();
            traversalQueue.Enqueue(new int[] { 0, 0 });
            bool[,] visited = new bool[n, n];
            visited[0, 0] = true;

            while (traversalQueue.Count > 0)
            {
                int[] curr = traversalQueue.Dequeue();
                if (curr[0] == n - 1 && curr[1] == n - 1)
                {
                    return true;
                }
                foreach (var d in dir)
                {
                    int di = curr[0] + d[0];
                    int dj = curr[1] + d[1];
                    if (IsValidCell(grid, di, dj) && !visited[di, dj] && grid[di, dj] >= minSafeness)
                    {
                        visited[di, dj] = true;
                        traversalQueue.Enqueue(new int[] { di, dj });
                    }
                }
            }

            return false;
        }

        private bool IsValidCell(int[,] mat, int i, int j)
        {
            int n = mat.GetLength(0);
            return i >= 0 && j >= 0 && i < n && j < n;
        }

        //List<(int, int)> indexesOfThieves = new List<(int, int)> ();
        //public int MaximumSafenessFactors(List<List<int>> grid)
        //{
        //    int gridWrapperLength = grid.Count() - 1;
        //    int gridWrapperLastLength = grid[gridWrapperLength].Count() - 1;
        //    if (grid[0][0] == 1 || grid[gridWrapperLength][gridWrapperLastLength] == 1)
        //    {
        //        return 0;
        //    }
        //    for (int i = 0; i < grid.Count(); i++)
        //    {
        //      var index =  grid[i].IndexOf(1);
        //        if (index > 0)
        //        {
        //            indexesOfThieves.Add((i,index));
        //        }
        //    }

        //    return 1;
        //}
    }
}
