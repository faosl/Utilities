using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.ConsoleApp
{
    public class ParenthesisExpression
    {
        public static bool Verify(string input)
        {
            var n = input.Length;
            var powResult = (int)Math.Pow(2, n);
            var allValidParentesisExpressions = new List<string>();

            _ = int.TryParse(input, out int result);

            if (n % 2 == 1)
            {
                return false;
            }

            for (int i = 0; i < powResult; i++)
            {
                var parentesisExpression = Convert.ToString(i, 2)
                    .PadLeft(n, '0')
                    .Replace('0', ')').Replace('1', '(');

                if (IsValid(parentesisExpression))
                {
                    allValidParentesisExpressions.Add(parentesisExpression);
                }
            }

            return allValidParentesisExpressions.Any(x => x == input);

        }

        private static bool IsValid(string expression)
        {
            var charsToClose = new List<char>();

            foreach (char @char in expression)
            {
                if (@char == '(')
                {
                    charsToClose.Add(@char);
                    continue;
                }

                if (@char == ')' && !charsToClose.Remove('('))
                {
                    return false;                 
                }
            }

            return charsToClose.Count == 0;
        }

    }
}
