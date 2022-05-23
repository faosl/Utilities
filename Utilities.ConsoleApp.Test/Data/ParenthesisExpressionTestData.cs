using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.ConsoleApp.Test.Data
{
    public class ParenthesisExpressionTestData : TestDataBase
    {
        public override IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "((()))", true};
            yield return new object[] { "((())(", false };
        }
    }
}
