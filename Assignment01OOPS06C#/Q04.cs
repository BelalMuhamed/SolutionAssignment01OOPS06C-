using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOPS06C_
{
    public class hiringDate : IComparable<hiringDate>
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get { return day; }
            set
            {
                if (value < 1 || value > DateTime.DaysInMonth(Year, Month))
                    throw new ArgumentException("Invalid day for the given month and year.");
                day = value;
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Month must be between 1 and 12.");
                month = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("Year must be a positive number.");
                year = value;
            }
        }

        public hiringDate(int day, int month, int year)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public int CompareTo(hiringDate other)
        {
            if (other == null) return 1;

            if (Year != other.Year)
                return Year.CompareTo(other.Year);
            if (Month != other.Month)
                return Month.CompareTo(other.Month);
            return Day.CompareTo(other.Day);
        }

        public override string ToString()
        {
            DateTime date = new DateTime(Year, Month, Day);
            return date.ToString("d", CultureInfo.CurrentCulture);
        }
    }
   
    
}
