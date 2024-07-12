using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOPS06C_
{
    internal class hiringdate 
    {
		private int day;

		public int Day
		{
			get { return day; }
			set {
				if (value < 1 || value > DateTime.DaysInMonth(year, month))
					throw new ArgumentException("invalid day");
				
				day = value; 
			}
		}
		private int month;

		public int Month
		{
			get { return month; }
			set 
			{ 
				if(value>12 ||value<0)
					throw new ArgumentException("invalid month ");
				month = value; 
			}
		}
		private int year;

		public int Year
		{
			get { return year; }
			set 
			{ 
				if(value<1)
					throw new ArgumentException("invalid year ");

				year = value;
			}
		}
		public hiringdate(int day, int month, int year)
		{
			this.day = day;	
			this.month = month;
			this.year = year;
		}
        public override string ToString()
        {
            return $"{Year}-{Day}-{Month}";
        }
    }
}
