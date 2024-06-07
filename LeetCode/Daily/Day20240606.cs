namespace LeetCode.Daily
{
    public class Day20240606
    {
        public bool IsItCanGrouped(int[] array, int numberOfGroups)
        {
            if (array.Length % numberOfGroups != 0)
            {
                return false;
            }
            if (numberOfGroups == 1)
            {
                return true;
            }

            Array.Sort(array);
            var newArrayList = array.ToList();
            var step = -1;

            for (var i = 0; i < newArrayList.Count;)
            {
                int sum = 1;
                var prev = newArrayList[i];
                for (var j = i + 1; j < newArrayList.Count;)
                {

                    var diff = prev - newArrayList[j];
                    if (diff < step)
                    {
                        return false;
                    }

                    if (diff == step)
                    {
                        sum++;
                        prev = newArrayList[j];
                        newArrayList.RemoveAt(j);
                        if (sum == numberOfGroups)
                        {
                            break;
                        }
                    }
                    else
                    {
                        j++;
                        if (j == newArrayList.Count)
                        {
                            return false;
                        }
                    }
                }
                newArrayList.RemoveAt(i);
            }
            return true;
        }
    }
}
