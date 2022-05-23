using System;
using System.Collections.Generic;
using Utilities.ConsoleApp.Test.Data;
using Xunit;

namespace Utilities.ConsoleApp.Test
{
    public class CustomIntervalAppointmentConfigurarionTest
    {
        [Theory]
        [ClassData(typeof(DatesBasedOnDaysTestData))]
        public void HaveToGetNextDatesBasedOnDaysSuccessfully(DateTime startConfigurationDate,
            DateTime actualInitialDate,
            DateTime actualEndDate,
            int timesInDays,
            List<DateTime> expectedNextDates)
        {
            //Act

            var actualNextDates = CustomIntervalAppointmentConfigurarion.GetNextDates(
                   startConfigurationDate,
                   actualInitialDate,
                   actualEndDate,
                   timesInDays
            );

            //Assert            
            Assert.Equal(expectedNextDates, actualNextDates);            

        }


        [Theory]
        [ClassData(typeof(DatesBasedOnMonthsTestData))]
        public void HaveToGetNextDatesBasedOnMonthsSuccessfully(
            DateTime startConfigurationDate,
            DateTime actualInitialDate,
            DateTime actualEndDate,
            int timesMonths,
            List<DateTime> expectedNextDates)
        {
           
            var actualNextDates = CustomIntervalAppointmentConfigurarion.GetNextDatesBasedMonths(
                 startConfigurationDate,
                 actualInitialDate,
                 actualEndDate,
                 timesMonths);

            //Assert            
            Assert.Equal(expectedNextDates, actualNextDates);

        }


    }
}