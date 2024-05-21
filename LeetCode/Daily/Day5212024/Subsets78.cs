namespace LeetCode.Daily.Day5212024
{
    public class Subsets78
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>() { new List<int>() };
            Subsets(nums, 0, result);
            return result;
        }

        public void Subsets(int[] nums, int index, IList<IList<int>> result)
        {
            if (nums.Length == index)
            {
                return;
            }

            int currentResultCount = result.Count;
            for (int i = 0; i < currentResultCount; i++)
            {

                var newSubset = new List<int>(result[i]);
                newSubset.Add(nums[index]);
                result.Add(newSubset);
            }

            Subsets(nums, index + 1, result);
        }
        //another, not mine solution
        //private List<IList<int>> output = new List<IList<int>>();
        //private int n, k;

        //private void backtrack(int first, List<int> curr, int[] nums)
        //{
        //    // if the combination is done
        //    if (curr.Count == k)
        //        output.Add(new List<int>(curr));


        //    for (int i = first; i < n; ++i)
        //    {
        //        // Add i into the current combination
        //        curr.Add(nums[i]);
        //        // Use next integers to complete the combination
        //        backtrack(i + 1, curr, nums);
        //        // backtrack
        //        curr.RemoveAt(curr.Count - 1);
        //    }
        //}

        //public IList<IList<int>> Subsets(int[] nums)
        //{
        //    n = nums.Length;
        //    for (k = 0; k < n + 1; ++k)
        //    {
        //        backtrack(0, new List<int>(), nums);
        //    }

        //    return output;
        //}
    }
}
