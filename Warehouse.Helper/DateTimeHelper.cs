using System.Globalization;

namespace Warehouse.Helper
{
    using System;

    public static class DateTimeHelper
    {
        private static readonly string[] MonthAlphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L"};

        public static string ConvertMonthToAlphabet(int month)
        {
            
            if (month > 12)
            {
                throw new InvalidCastException("Month is invalid. Should be between 1 to 12");
            }

            return MonthAlphabet[month - 1];
        }

        public static DateTime NextMonth(this DateTime date)
        {
            if (date.Day != DateTime.DaysInMonth(date.Year, date.Month))
                return date.AddMonths(1);
            else
                return date.AddDays(1).AddMonths(1).AddDays(-1);
        }

        public static DateTime PreviousMonth(this DateTime date, int idx = 1)
        {
            if (date.Day != DateTime.DaysInMonth(date.Year, date.Month))
                return date.AddMonths(-idx);
            else
                return date.AddDays(1).AddMonths(-idx).AddDays(-1);
        }

        public static DateTime GetDateTime(int date, int month, int year)
        {
            return DateTime.ParseExact(
                string.Format("{0}/{1}/{2}", date.ToString(CultureInfo.InvariantCulture), month.ToString("d2"), year)
                , "dd/MM/yyyy"
                , null);
        }

        public static bool IsBetween(this DateTime date, DateTime from, DateTime to)
        {
            return DateTime.Compare(date, from) > 0 && DateTime.Compare(date, to) < 0;
        }
    }
}
