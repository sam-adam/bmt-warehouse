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
    }
}
