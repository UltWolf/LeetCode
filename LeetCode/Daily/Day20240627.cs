namespace LeetCode.Daily
{
    public class Day20240627
    {
        public int FindCenter(int[][] edges)
        {
            Dictionary<int, int> nodeCount = new Dictionary<int, int>();

            foreach (var edge in edges)
            {
                int u = edge[0];
                int v = edge[1];

                if (nodeCount.ContainsKey(u))
                {
                    nodeCount[u]++;
                }
                else
                {
                    nodeCount[u] = 1;
                }

                if (nodeCount.ContainsKey(v))
                {
                    nodeCount[v]++;
                }
                else
                {
                    nodeCount[v] = 1;
                }
            }

            foreach (var kvp in nodeCount)
            {
                if (kvp.Value == edges.Length)
                {
                    return kvp.Key;
                }
            }

            return -1;
        }
    }
}
