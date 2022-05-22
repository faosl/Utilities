using System;
using System.Collections.Generic;
using Xunit;

namespace Utilities.ConsoleApp.Test
{
    public class CustomIntervalAppointmentConfigurarionTest
    {
        [Fact]
        public void HaveToGetNextDatesBasedOnDaysSuccessfully()
        {
            //Arrange
            var startConfigurationDate = new DateTime(2022, 04, 17);
            var actualInitialDate = new DateTime(2022, 05, 01);
            var actualEndDate = new DateTime(2022, 05, 14);
            var timesInDays = 5;

            var expectedNextDates = new List<DateTime>()
            {
                new DateTime(2022,05,02),
                new DateTime(2022,05,07),
                new DateTime(2022,05,12),
            };

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

        [Fact]
        public void HaveToGetNextDatesBasedOnWeeksSuccessfully()
        {
            //Arrange
            var startConfigurationDate = new DateTime(2022, 04, 17);
            var actualInitialDate = new DateTime(2022, 05, 01);
            var actualEndDate = new DateTime(2022, 05, 14);
            var timesInDays = 14;

            var expectedNextDates = new List<DateTime>()
            {
                new DateTime(2022,05,01),
            };

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

        [Fact]
        public void HaveToGetNextDatesBasedOnMonthsSuccessfully()
        {

#warning Verificar a exceção de 30 de fevereiro
            //Arrange
            var startConfigurationDate = new DateTime(2022, 01, 14);
            var actualInitialDate = new DateTime(2022, 05, 01);
            var actualEndDate = new DateTime(2022, 05, 14);
            
            var timesIn3Months = 3;

            var expectedNextDates3Months = new List<DateTime>()
            {
            };

            var timesMonths = 1;

            var expectedNextDates = new List<DateTime>()
            {
                new DateTime(2022, 05, 14)
            };

            //Act

            var actualNextDates3Months = CustomIntervalAppointmentConfigurarion.GetNextDatesBasedMonths(
                   startConfigurationDate,
                   actualInitialDate,
                   actualEndDate,
                   timesIn3Months
            );


            var actualNextDates = CustomIntervalAppointmentConfigurarion.GetNextDatesBasedMonths(
                 startConfigurationDate,
                 actualInitialDate,
                 actualEndDate,
                 timesMonths
          );

            //Assert            
            Assert.Equal(expectedNextDates3Months, actualNextDates3Months);
            Assert.Equal(expectedNextDates, actualNextDates);

        }

        [Fact]
        public void HaveToGetNextDatesBasedOnYearSuccessfully()
        {
            //Arrange
            var startConfigurationDate = new DateTime(2022, 04, 17);
            var actualInitialDate = new DateTime(2022, 05, 01);
            var actualEndDate = new DateTime(2022, 05, 14);
            var timesInDays = 5;

            var expectedNextDates = new List<DateTime>()
            {
                new DateTime(2022,05,02),
                new DateTime(2022,05,07),
                new DateTime(2022,05,12),
            };

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
    }
}