namespace LeetCode.Daily
{
    public class Day20240605
    {
        //        Input: words = ["bella","label","roller"]
        //        Output: ["e","l","l"]
        //        Example 2:

        //Input: words = ["cool","lock","cook"]
        //        Output: ["c","o"]
        public List<string> Calculate(string[] array)
        {
            Array.Sort(array);
            List<string> list = new List<string>();
            for (var s = 0; s < array[0].Length; s++)
            {
                var letter = array[0][s];

                var isFind = false;
                for (var i = 1; i < array.Length; i++)
                {
                    isFind = false;
                    for (var j = 0; j < array[i].Length; j++)
                    {
                        if (array[i][j] == letter)
                        {
                            isFind = true;
                            array[i] = array[i].Remove(j, 1);
                            break;
                        }
                    }
                    if (isFind == false)
                    {
                        break;
                    }
                }
                if (isFind != false)
                {
                    list.Add(letter.ToString());
                }
            }
            return list;
        }
    }
}
