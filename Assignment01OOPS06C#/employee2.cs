using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOPS06C_
{
    internal struct employee2
    {

        private int id;

        public int Id
        {
            
            get { return id; }
            set { id = value; }
        }
        public int Age { get; set; }

        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Id} : {Name} : {Age}";
        }

    }
}
