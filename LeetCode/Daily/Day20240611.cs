namespace LeetCode.Daily
{
    public class Day20240611
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length];
            int index = 0;
            Array.Sort(arr1);
            for (int i = 0; i < arr2.Length; i++)
            {
                for (var j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        result[index++] = arr1[j];
                    }
                }
            }
            for (var i = index; i < result.Length; i++)
            {
                result[i] = arr1[i];
            }
            return result;
        }
    }
}
