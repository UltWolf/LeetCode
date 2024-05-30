namespace LeetCode.Daily
{
    public class Day20240530
    {
        public int count = 0;
        public const int sizeOfTriplet = 2;
        public int CountTriplets(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                int xorA = 0;

                for (int j = i + 1; j < arr.Length; ++j)
                {
                    xorA ^= arr[j - 1];

                    int xorB = 0;

                    for (int k = j; k < arr.Length; ++k)
                    {
                        xorB ^= arr[k];

                        if (xorA == xorB)
                        {
                            ++count;
                        }
                    }
                }
            }

            //for (int i = 0; i < arr.Length - 2; i++)
            //{
            //    CountTriplets(i, arr, arr[i], 0);
            //}
            return count;
        }
        //public void CountTriplets(int index, int[] array, int curr, int size)
        //{
        //    //if (index >= array.Length)
        //    //{
        //    //    return;
        //    //}
        //    //if (size == sizeOfTriplet)
        //    //{
        //    //    if (curr != 0)
        //    //    {
        //    //        count++;
        //    //    }
        //    //    return;
        //    //}
        //    //for (int i = index + 1; i < array.Length; i++)
        //    //{
        //    //    curr ^= array[i];
        //    //    CountTriplets(i, array, curr, ++size);
        //    //}
        //}
    }
}
