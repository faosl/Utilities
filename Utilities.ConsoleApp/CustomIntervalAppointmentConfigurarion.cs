using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.ConsoleApp
{
    public class CustomIntervalAppointmentConfigurarion
    {
        public static List<DateTime> GetNextDates(DateTime startConfigurationDate,
            DateTime actualInitialDate,
            DateTime actualEndDate,
            int timesInDays)
        {
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
            var diffMonths = ((actualInitialDate.Year - startConfigurationDate.Year) * 12) + actualInitialDate.Month - startConfigurationDate.Month;

            var diffDays = startConfigurationDate.Day - actualInitialDate.Day;
            
            if (diffDays > 0)
            {
                actualInitialDate = actualInitialDate.AddDays(diffDays);
            }            

            var lastDateSelected = actualInitialDate.AddMonths(-(diffMonths % timesInMonths));
            
            var nextDates = new List<DateTime>();            

            while (lastDateSelected >= actualInitialDate && lastDateSelected <= actualEndDate)
            {
                nextDates.Add(lastDateSelected);
                lastDateSelected = lastDateSelected.AddMonths(timesInMonths);
            }

            return nextDates;
        }
    }
}
