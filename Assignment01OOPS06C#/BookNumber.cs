using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOPS06C_
{
    internal struct BookNumber
    {
        private string[] names;
        private long[] numbers;
        private int size;

        public BookNumber(int _size)
        {
            size = _size;
            names = new string[_size];
            numbers = new long[_size];
        }

        public void Add(int index, string name, long number)
        {
            if (index >= 0 && index < size && name is not null)
            {
                names[index] = name;
                numbers[index] = number;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range or name is null.");
            }
        }

        public long this[string name]
        {
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        numbers[i] = value;
                        return;
                    }
                }
                
            }
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        return numbers[i];
                    }
                }
                return -1; 
            }
        }
    }
}