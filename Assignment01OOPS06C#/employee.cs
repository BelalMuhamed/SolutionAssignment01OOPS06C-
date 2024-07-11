using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOPS06C_
{
    struct employee
    {
        private int id;
        private int salary;
        private string name;
       
        public void SetId(int id)
        {
            this.id = id;   
             
        }
        public int GetId()
        {
            return this.id;

        }
        public void SetSalary(int salary)
        {
            this.salary = salary;

        }
        public int GetSalary()
        {
            return this.salary;

        }
        public void SetName(string name)
        {
            this.name = name;

        }
        public string GetName()
        {
            return this.name;

        }
        

    }
}
