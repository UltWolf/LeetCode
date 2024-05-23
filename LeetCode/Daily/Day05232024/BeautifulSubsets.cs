namespace LeetCode.Daily.Day05232024
{
    public class BeautifulSubsets
    {
        List<List<int>> beautifulSubsets = new List<List<int>>();
        public int[] numsArray;
        public int absDiff;

        private int _k;
        private int[] _nums;
        private int _count;
        private List<int> _set;

        public int BeautifulSubsetsCalc(int[] nums, int k)
        {

            (_k, _nums, _set) = (k, nums, new(nums.Length));
            Array.Sort(_nums);
            FindSubsets();
            return _count;
        }

        private void FindSubsets(int i = 0)
        {
            if (i == _nums.Length)
            {
                if (_set.Count > 0) _count++;
                return;
            }

            if (!_set.Contains(_nums[i] - _k))
            {
                _set.Add(_nums[i]);
                FindSubsets(i + 1);
                _set.Remove(_nums[i]);
            }

            FindSubsets(i + 1);
        }

        //public int BeautifulSubsetsCalc(int[] nums, int k)
        //{
        //    numsArray = nums;
        //    Array.Sort(numsArray);
        //    absDiff = k;
        //    Back(0, 0, new Stack<int>());
        //    int totalElements = 0;
        //    foreach (var innerList in beautifulSubsets)
        //    {
        //        totalElements += innerList.Count;
        //    }
        //    return totalElements;
        //}

        //public void Back(int diff, int index, List<int> beafSub)
        //{
        //    if (index == numsArray.Length)
        //    {
        //        return;
        //    } 

        //    if (Math.Abs(diff) != absDiff || beafSub.Count == 1)
        //    {
        //        beautifulSubsets.Add(beafSub);
        //    }
        //    for (var i = index; i < numsArray.Length; i++)
        //    {
        //        var newDiff = diff - numsArray[index];
        //        beafSub.Add(numsArray[i]);
        //        Back(newDiff, index + 1, beafSub);
        //        beafSub.Remove(beafSub.Count - 1);
        //    }
        //}
        //public void Back(int diff, int index, Stack<int> beafSub)
        //{
        //    if (index == numsArray.Length)
        //    {
        //        return;
        //    }
        //    //diff -= numsArray[index];

        //    if (Math.Abs(diff) != absDiff || beafSub.Count == 1)
        //    {
        //        beautifulSubsets.Add(beafSub.ToList());
        //    }
        //    for (var i = index; i < numsArray.Length; i++)
        //    {
        //        var newDiff = diff - numsArray[index];
        //        beafSub.Push(numsArray[i]);
        //        Back(newDiff, index + 1, beafSub);
        //        beafSub.Pop();
        //    }
        //}
    }
}
