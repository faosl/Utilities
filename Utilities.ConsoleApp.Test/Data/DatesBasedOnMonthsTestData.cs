using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.ConsoleApp.Test.Data
{
    public class DatesBasedOnMonthsTestData : TestDataBase
    {
        public override IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new DateTime(2022, 01, 14), new DateTime(2022, 05, 01), new DateTime(2022, 05, 14), 1, new List<DateTime>()
            {
                new DateTime(2022, 05, 14)
            }};

            yield return new object[] { new DateTime(2022, 01, 14), new DateTime(2022, 05, 01), new DateTime(2022, 05, 14), 3, new List<DateTime>()
            {

            }};

            yield return new object[] { new DateTime(2022, 05, 23), new DateTime(2023, 05, 01), new DateTime(2023, 05, 31), 12, new List<DateTime>()
            {
                new DateTime(2023, 05, 23)
            }};

            yield return new object[] { new DateTime(2020, 02, 29), new DateTime(2020, 02, 29), new DateTime(2024, 02, 29), 12, new List<DateTime>()
            {
                new DateTime(2020, 02, 29),
                new DateTime(2024,02,29)
            }};

            yield return new object[] { new DateTime(2022, 01, 31), new DateTime(2022, 02, 01), new DateTime(2022, 03, 31), 1, new List<DateTime>()
            {
                new DateTime(2022, 03, 31)
            }};

            yield return new object[] { new DateTime(2022, 01, 31), new DateTime(2022, 01, 31), new DateTime(2022, 12, 31), 1, new List<DateTime>()
            {
                new DateTime(2022, 01, 31),
                new DateTime(2022, 03, 31),
                new DateTime(2022, 05, 31),
                new DateTime(2022, 07, 31),
                new DateTime(2022, 08, 31),
                new DateTime(2022, 10, 31),
                new DateTime(2022, 12, 31),
            }};

        }
    }
}
