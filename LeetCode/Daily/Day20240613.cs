namespace LeetCode.Daily
{
    public class Day20240613
    {
        public int MinMovesToSeat(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);
            var result = 0;
            for (var i = 0; i < seats.Length; i++)
            {
                result += Math.Abs(seats[i] - students[i]);
            }
            return result;
        }
    }
}
