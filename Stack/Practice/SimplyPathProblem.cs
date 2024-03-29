using System.Text;

namespace Stack.Practice
{
    internal class SimplyPathProblem
    {
        public string SimplifyPath(string path)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char ch in path)
            {
                if (stack.Count == 0)
                {
                    if (ch != '/')
                    {
                        stack.Push('/');
                    }
                    if (ch != '.')
                    {
                        stack.Push(ch);
                    }
                }
                else
                {
                    char top = stack.Peek();
                    if (top != '/' || ch != '/' )
                    {
                        stack.Push(ch);
                    }
                }
            }
            if(stack.Peek() == '/')
            {
                stack.Pop();
            }
            string result = string.Empty;
            while (stack.Count > 0)
            {
                string dots = string.Empty;
                if(stack.Peek() == '.')
                {
                    while(stack.Peek() == '.')
                    {
                        dots += stack.Pop();
                    }
                }
                if (!string.IsNullOrEmpty(dots))
                {
                    if(dots.Length > 2)
                    {
                        result = dots + result;
                    }
                }
                else
                {
                    result = stack.Pop() + result;
                }
            }
            return result;
        }
    }
}
