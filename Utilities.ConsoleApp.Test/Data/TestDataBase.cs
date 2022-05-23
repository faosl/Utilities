using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.ConsoleApp.Test.Data
{
    public abstract class TestDataBase : IEnumerable<object[]>
    {
        public abstract IEnumerator<object[]> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
