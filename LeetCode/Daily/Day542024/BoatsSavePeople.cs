namespace LeetCode.Daily.Day542024
{
    public class BoatsSavePeople
    {
        //my solution
        public int NumRescueBoats(int[] people, int limit)
        {
            var list = people.ToList();
            list.Sort((a, b) => { return b.CompareTo(a); });
            int numb = 0;
            for (var i = 0; i < list.Count(); i++)
            {

                if (list[i] == limit)
                {
                    numb++;
                    continue;
                }
                for (var j = list.Count - 1; j > i; j--)
                {
                    if (list[i] + list[j] <= limit)
                    {
                        list.Remove(list[j]);
                        break;
                    }
                }
                numb++;
            }
            return numb;
        }
        //optimized solution
        public int NumRescueBoats2(int[] people, int limit)
        {

            Array.Sort(people);
            int i = 0;
            int j = people.Length - 1;
            int ans = 0;
            while (i <= j)
            {
                if (people[i] + people[j] <= limit)
                    i++;

                j--;
                ans++;
            }
            return ans;
        }
    }
}
