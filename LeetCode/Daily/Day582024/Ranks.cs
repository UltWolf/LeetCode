namespace LeetCode.Daily.Day582024
{
    public class Ranks
    {
        public string[] FindRelativeRanks(int[] score)
        {
            var rank = new string[score.Length];
            var originalScore = (int[])score.Clone();
            Array.Sort(score,
                new Comparison<int>(
                (c, p) => { return p.CompareTo(c); }
                )
                );
            for (var i = 0; i < originalScore.Length; i++)
            {
                for (var j = 0; j < score.Length; j++)
                {
                    if (originalScore[i] == score[j])
                    {

                        if (j == 0)
                        {
                            rank[i] = "Gold Medal";
                        }
                        else if (j == 1)
                        {
                            rank[i] = "Silver Medal";
                        }
                        else if (j == 2)
                        {
                            rank[i] = "Bronze Medal";
                        }
                        else
                        {
                            rank[i] = (j + 1).ToString();
                        }
                        break;
                    }
                }
            }
            return rank;
        }
    }
}
