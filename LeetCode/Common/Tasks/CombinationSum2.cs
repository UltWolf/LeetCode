namespace LeetCode.Common.Tasks
{
    public class CombinationSum2
    {

        public int[] candidatesArray;
        public int lengthArray;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            candidatesArray = candidates;
            lengthArray = candidatesArray.Length;
            Array.Sort(candidatesArray);

            List<IList<int>> result = new List<IList<int>>();
            var cur = new List<int>();

            Back(target, result, cur, 0);
            return result;
        }
        public void Back(int target, List<IList<int>> result, List<int> curr, int index)
        {

            if (target == 0)
            {
                result.Add(new List<int>(curr));
                return;
            }
            if (target < 0)
            {
                return;
            }
            for (int i = index; i < lengthArray; i++)
            {
                if (i > index && candidatesArray[i] == candidatesArray[i - 1])
                {
                    continue;
                }
                curr.Add(candidatesArray[i]);
                Back(target - candidatesArray[i], result, curr, i + 1); ;
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
}
