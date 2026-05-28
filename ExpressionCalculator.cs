using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace InfinitePrecisionCalculator
{
    public class ExpressionCalculator : ICalculator
    {
        public string Calculate(string expression)
        {
            try
            {
                List<string> postfix = ToPostfix(expression);

                BigNumber result = EvaluatePostfix(postfix);

                return result.ToString();
            }
            catch
            {
                return "Помилка";
            }
        }

        private int Priority(string op)
        {
            if (op == "+" || op == "-")
                return 1;

            if (op == "*" || op == "/")
                return 2;

            return 0;
        }

        private List<string> ToPostfix(string expression)
        {
            List<string> output = new List<string>();
            Stack<string> operators = new Stack<string>();

            string number = "";

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];

                if (char.IsDigit(c) || c == '.')
                {
                    number += c;
                }
                else
                {
                    if (number != "")
                    {
                        output.Add(number);
                        number = "";
                    }

                    if (c == '(')
                    {
                        operators.Push(c.ToString());
                    }
                    else if (c == ')')
                    {
                        while (operators.Peek() != "(")
                        {
                            output.Add(operators.Pop());
                        }

                        operators.Pop();
                    }
                    else if ("+-*/".Contains(c))
                    {
                        while (
                            operators.Count > 0 &&
                            Priority(operators.Peek()) >= Priority(c.ToString())
                        )
                        {
                            output.Add(operators.Pop());
                        }

                        operators.Push(c.ToString());
                    }
                }
            }

            if (number != "")
            {
                output.Add(number);
            }

            while (operators.Count > 0)
            {
                output.Add(operators.Pop());
            }

            return output;
        }

        private BigNumber EvaluatePostfix(List<string> postfix)
        {
            Stack<BigNumber> stack = new Stack<BigNumber>();

            foreach (string token in postfix)
            {
                if (double.TryParse(token, out _))
                {
                    stack.Push(BigNumber.Parse(token));
                }
                else
                {
                    BigNumber b = stack.Pop();
                    BigNumber a = stack.Pop();

                    switch (token)
                    {
                        case "+":
                            stack.Push(BigNumber.Add(a, b));
                            break;

                        case "-":
                            stack.Push(BigNumber.Subtract(a, b));
                            break;

                        case "*":
                            stack.Push(BigNumber.Multiply(a, b));
                            break;

                        case "/":
                            stack.Push(BigNumber.Divide(a, b));
                            break;
                    }
                }
            }

            return stack.Pop();
        }
    }
}
