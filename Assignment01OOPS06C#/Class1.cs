using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOPS06C_
{
    internal struct Point
    {
        public double x { get; set; }
        public double y { get; set; }
        public double GetCoordinateFromUser(string coordinateName)
        {
            double coordinate;
            while (true)
            {
                Console.Write($"{coordinateName}: ");
                if (double.TryParse(Console.ReadLine(), out coordinate))
                {
                    return coordinate;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
        
    }
}
