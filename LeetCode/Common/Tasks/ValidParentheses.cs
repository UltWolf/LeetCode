namespace LeetCode.Common.Tasks
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                switch (c)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(c);
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                            return false;
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                            return false;
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                            return false;
                        break;
                }
            }

            return stack.Count == 0;
        }
        //public bool IsValid(string s)
        //{
        //    var stack = new Stack<char>();
        //    var matchingParentheses = new Dictionary<char, char>
        //{
        //    { ')', '(' },
        //    { '}', '{' },
        //    { ']', '[' }
        //};

        //    foreach (var c in s)
        //    {

        //        if (c == '(' || c == '{' || c == '[')
        //        {
        //            stack.Push(c);
        //        }
        //        //if (matchingParentheses.ContainsValue(c))
        //        //{
        //        //    stack.Push(c);
        //        //}
        //        else if (matchingParentheses.ContainsKey(c))
        //        {
        //            if (stack.Count == 0 || stack.Pop() != matchingParentheses[c])
        //            {
        //                return false;
        //            }
        //        }
        //    }

        //    return stack.Count == 0;
        //}
        //(char, char)[] validStatements = new (char, char)[] { new('(', ')'), new('{', '}'), new('[', ']') };
        //public bool IsValid(string s)
        //{
        //    var charArray = s.ToCharArray();
        //    int index = 0;
        //    var isValid = false;
        //    for (; index < charArray.Length; index++)
        //    {
        //        var openStatement = validStatements.FirstOrDefault(f => f.Item1.Equals(charArray[index]));
        //        if (openStatement.Item1 != default(char))
        //        {
        //            isValid = IsValid(charArray, index + 1, openStatement.Item2).Item2;
        //        }
        //        if (!isValid)
        //        {
        //            return false;
        //        }

        //    }
        //    return isValid;

        //}

        //public (int, bool) IsValid(char[] charArray, int index, char? searchedTerm)
        //{
        //    var isValid = false;
        //    for (; index < charArray.Length; index++)
        //    {
        //        var openStatement = validStatements.FirstOrDefault(f => f.Item1.Equals(charArray[index]));
        //        if (searchedTerm.HasValue && charArray[index] == searchedTerm)
        //        {
        //            return (index, true);
        //        }
        //        if (openStatement.Item1 != default(char))
        //        {
        //            return IsValid(charArray, index + 1, openStatement.Item2);
        //        }
        //        if (!isValid)
        //        {
        //            return (0, false);
        //        }

        //    }
        //    return (0, isValid);
        //}



        //public bool IsValid(char[] charArray, int index, char? searchedTerm)
        //{
        //    for (; index < charArray.Length; index++)
        //    {
        //        if (charArray[index] == '(')
        //        {
        //            isFinded = false;
        //            if (!IsValid(charArray, index + 1, (char)((int)charArray[index] + 1)))
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                isFinded = true;
        //            }

        //        }
        //        else if (charArray[index] == '[' || charArray[index] == '{')
        //        {
        //            isFinded = false;
        //            if (!IsValid(charArray, index + 1, (char)((int)charArray[index] + 2)))
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                isFinded = true;
        //            }

        //        }
        //        if (searchedTerm.HasValue && charArray[index] == searchedTerm)
        //        {
        //            return true;
        //        }
        //    }
        //    return isFinded;

        //}
    }
}
