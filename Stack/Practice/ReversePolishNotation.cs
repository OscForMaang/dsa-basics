namespace Stack.Practice
{
    internal class ReversePolishNotation
    {
        public int EvalRPN(string[] tokens)
        {
            string[] op = new string[]
            {
                "+", "-", "*",  "/"
            };
            Stack<int> stack = new Stack<int>();
            foreach (string token in tokens)
            {
                if (op.Contains(token))
                {
                    int num1 = stack.Pop();
                    int num2 = stack.Pop();

                    if(token == "+")
                    {
                        stack.Push(num1 + num2);
                    }else if(token == "-")
                    {
                        stack.Push(num1 - num2);
                    }else if(token == "*")
                    {
                        stack.Push(num1 * num2);
                    }else if(token == "/")
                    {
                        stack.Push(num1 * num2);
                    }
                }
                else
                {
                    stack.Push(Convert.ToInt32(token));
                }
            }

            return stack.Peek();
        }
    }
}
