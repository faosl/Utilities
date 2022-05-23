using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.ConsoleApp.Test.Data;
using Xunit;

namespace Utilities.ConsoleApp.Test
{
    public class ParenthesisExpressionTest
    {
        [Theory]
        [ClassData(typeof(ParenthesisExpressionTestData))]
        public void HaveToVerify(string input,bool expected)
        {
            var ok = ParenthesisExpression.Verify(input);

            Assert.Equal(expected, ok);
        }
    }
}
