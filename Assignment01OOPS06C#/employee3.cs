using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOPS06C_
{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }

    public enum Gender
    {
        Male,
        Female
    }

    public class HiringDate
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

        public HiringDate(int day, int month, int year)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public override string ToString()
        {
            DateTime date = new DateTime(Year, Month, Day);
            return date.ToString("d", CultureInfo.CurrentCulture);
        }
    }

    public class Employee
    {
        private int id;
        private string name;
        private Gender gender;
        private SecurityLevel securityLevel;
        private decimal salary;
        private HiringDate hireDate;

        public int Id
        {
            get { return id; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("ID must be a positive number.");
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be null or whitespace.");
                name = value;
            }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public SecurityLevel SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary must be a non-negative number.");
                salary = value;
            }
        }

        public HiringDate HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public Employee(int id, string name, Gender gender, SecurityLevel securityLevel, decimal salary, HiringDate hireDate)
        {
            Id = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return string.Format(
                "ID: {0}, Name: {1}, Gender: {2}, Security Level: {3}, Salary: {4}, Hire Date: {5}",
                Id,
                Name,
                Gender,
                SecurityLevel,
                string.Format(CultureInfo.CurrentCulture, "{0:C}", Salary),
                HireDate
            );
        }
    }

}
