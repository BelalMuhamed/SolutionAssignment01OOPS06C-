using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOPS06C_
{
    enum security:byte 
    {
        guest, Developer, secretary , DBA
    }
    enum gender :byte
    {
        male,female 

    }
    internal class employee
    {
        private int id;
        private string name;
        private security securityLevel;
        private double salary;
        private DateTime hiredate;
        private gender gender;
        public int Id { get; set; }
        public string Name { get; set; }
        public security SecurityLevel { get; set; }
        public double Salary { get; set; }
        public DateOnly HireDate { get; set; }
        public gender Gender { get; set; }
        public employee(int id, string name, security securityLevel, double salary, DateTime hiredate, gender gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            this.hiredate = hiredate;
            Gender = gender;
            
        }
        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Gender: {2}, Security Level: {3}, Salary: {4}, Hire Date: {5}",
            Id,
            Name,
            Gender,
            SecurityLevel,
            string.Format(CultureInfo.CurrentCulture, "{0:C}", Salary),
            HireDate.ToString("d", CultureInfo.CurrentCulture));
        }
    }
}
