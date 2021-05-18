using Nager.Date;
using System;
using System.Linq;

namespace NextBusinessDay
{
    class NextDay
    {
        public static DateTime GetAddDays(DateTime dateTime)
        {
            var publicHolidays = DateSystem.GetPublicHoliday(dateTime, dateTime, CountryCode.BR);
            if (publicHolidays.Count() > 0)
            {

                Console.WriteLine();
                if (dateTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    dateTime = dateTime.AddDays(2);
                }
                else if (dateTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    dateTime = dateTime.AddDays(1);
                }
                else
                {
                    dateTime = dateTime.AddDays(1);
                }
                Console.Write("Holiday - Next working day: ");
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Saturday)
            {
                dateTime = dateTime.AddDays(2);
                Console.Write("Saturday - Next working day: ");
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                dateTime = dateTime.AddDays(1);
                Console.Write("Sunday - Next working day: ");
            }
            else
            {
                Console.Write("Working day: ");
            }
            return NextDay.GetNextDay(dateTime);
        }
        public static DateTime GetNextDay(DateTime dateTime)
        {
            Console.Write(dateTime.ToString("dd/MM/yyyy"));
            Console.Write(" - ");
            Console.WriteLine(dateTime.ToString("dddd"));
            return dateTime;
        }
    }
}
