using System;
using System.Data;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace october_cw
{
    // You are given a year as integer (e. g. 2001). You should return the most 
    // frequent day(s) of the week in that year. The result has to be a list of days
    // sorted by the order of days in week (e. g. ['Monday', 'Tuesday'], ['Saturday', 'Sunday'], ['Monday', 'Sunday']).
    // Week starts with Monday.

    // Input: Year as an int.

    // Output: The list of most frequent days sorted by the order of days in week 
    // (from Monday to Sunday).
    class Program
    {
        public static string[] MostFrequentDays(int year)
        {
            var days = new Dictionary<string, int>
            {
                { "Monday", 0 },
                { "Tuesday", 0 },
                { "Wednesday", 0 },
                { "Thursday", 0 },
                { "Friday", 0 },
                { "Saturday", 0 },
                { "Sunday", 0 }
            };

            var y = new DateTime(year, 1, 1, new GregorianCalendar());

            while(y.Year.Equals(year))
            {
                days[y.DayOfWeek.ToString()]++;
                year = y.AddDays(1);
            }
            return days.Where(x => x.Value.Equals(days.Max(t => t.Value))).Select(x => x.Key).ToArray();

        }


        static void Main(string[] args)
        {
         MostFrequentDays(2923);

        }
    }
}
