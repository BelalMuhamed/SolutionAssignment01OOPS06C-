using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment01OOPS06C_
{

    public struct person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return $"{name} : {age}";
        }
    }




}


