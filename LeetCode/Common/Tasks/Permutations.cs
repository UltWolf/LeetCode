namespace LeetCode.Common.Tasks
{
    public class Permutations
    {
        public List<IList<int>> output = new List<IList<int>>();
        public int[] numArray;
        public int numArrayLength;
        public IList<IList<int>> Permute(int[] nums)
        {

            numArray = nums;
            numArrayLength = numArray.Length;
            Back(new List<int>());
            return output;
        }
        public void Back(List<int> nums)
        {
            if (nums.Count == numArrayLength)
            {
                output.Add(nums.ToList());
                return;
            }

            foreach (int i in numArray)
            {
                if (nums.Contains(i))
                {
                    continue;

                }
                nums.Add(i);
                Back(nums);
                nums.RemoveAt(nums.Count - 1);
            }

        }
        //public void Back(int index, Stack<int> nums)
        //{
        //    if (nums.Count == numArrayLength)
        //    {
        //        output.Add(nums.ToList());
        //        return;
        //    }
        //    for (int i = index; i < numArrayLength; i++)
        //    {
        //        nums.Push(numArray[i]);
        //        Back(i + 1, nums);
        //        nums.Pop();
        //    }

        //}
    }
}
