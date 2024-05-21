namespace LeetCode.Common.Tasks
{
    public class GenerateParentheses
    {
        public IList<string> output { get; set; } = new List<string>();
        public int countParent;
        public IList<string> GenerateParenthesis(int n)
        {
            countParent = n;
            GenerateParenthesis("", 0, 0);
            return output;
        }
        public void GenerateParenthesis(string result, int open, int closed)
        {
            if (open == countParent && closed == countParent)
            {
                output.Add(result);
                return;
            }
            if (open < countParent)
            {
                GenerateParenthesis(result + "(", open + 1, closed);
            }
            if (closed < open)
            {
                GenerateParenthesis(result + ")", open, closed + 1);
            }
        }
    }
}
