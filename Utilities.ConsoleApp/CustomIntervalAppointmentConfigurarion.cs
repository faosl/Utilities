using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.ConsoleApp
{
    public static class CustomIntervalAppointmentConfigurarion
    {
        public static List<DateTime> GetNextDates(DateTime startConfigurationDate,
            DateTime actualInitialDate,
            DateTime actualEndDate,
            int timesInDays)
        {
            if (actualInitialDate < startConfigurationDate)
            {
                actualInitialDate = startConfigurationDate;
            }

            var diffDays = (actualInitialDate - startConfigurationDate).TotalDays;

            var dayForNextDate = timesInDays - (diffDays % timesInDays);

            var lastDateSelected = new DateTime(actualInitialDate.Year,actualInitialDate.Month,actualInitialDate.Day);

            if (dayForNextDate < timesInDays)
            {
                lastDateSelected = actualInitialDate.AddDays(dayForNextDate);
            }            

            var nextDates = new List<DateTime>();           

            while (lastDateSelected >= actualInitialDate && lastDateSelected <= actualEndDate)
            {                
                nextDates.Add(lastDateSelected);
                lastDateSelected = lastDateSelected.AddDays(timesInDays);
            }

            return nextDates; 
        }

        public static List<DateTime> GetNextDatesBasedMonths(DateTime startConfigurationDate,
            DateTime actualInitialDate,
            DateTime actualEndDate,
            int timesInMonths)
        {

            if (actualInitialDate < startConfigurationDate)
            {
                actualInitialDate = startConfigurationDate;
            }

            var diffMonths = ((actualInitialDate.Year - startConfigurationDate.Year) * 12) + actualInitialDate.Month - startConfigurationDate.Month;               
           
            var lastDateSelected = actualInitialDate.AddMonths(-(diffMonths % timesInMonths));

            var nextDates = new List<DateTime>();            

            while (lastDateSelected >= actualInitialDate && lastDateSelected <= actualEndDate)
            {
                try
                {
                    lastDateSelected = new DateTime(lastDateSelected.Year, lastDateSelected.Month, startConfigurationDate.Day);
                }
                catch
                {
                    lastDateSelected = lastDateSelected.AddMonths(timesInMonths);
                    continue;
                }             

                nextDates.Add(lastDateSelected);
                lastDateSelected = lastDateSelected.AddMonths(timesInMonths);
            }

            return nextDates;
        }
    }
}
