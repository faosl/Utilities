using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.ConsoleApp.Test.Data
{
    public class DatesBasedOnDaysTestData : TestDataBase
    {
        public override IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new DateTime(2022, 04, 17), new DateTime(2022, 05, 01), new DateTime(2022, 05, 14), 5, new List<DateTime>()
            {
                new DateTime(2022,05,02),
                new DateTime(2022,05,07),
                new DateTime(2022,05,12),
            }};

            yield return new object[] { new DateTime(2022, 04, 17), new DateTime(2022, 05, 01), new DateTime(2022, 05, 14), 14, new List<DateTime>()
            {
                new DateTime(2022,05,01),
            }};

            yield return new object[] { new DateTime(2022, 04, 17), new DateTime(2022, 05, 01), new DateTime(2022, 05, 07), 13, new List<DateTime>()
            {

            }};
        }
    }
}
