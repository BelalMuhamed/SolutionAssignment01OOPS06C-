﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOPS06C_
{
     struct Point
    {
        public int x;
        public int y;
        public Point()
        {
            x = default; 
            y = default;
        }
        public Point(int _x, int _y) 
        {
            x = _x; 
            y= _y;
        }
        public override string ToString()
        {
            return $"({x},{y})";
        }
            
    }
}
