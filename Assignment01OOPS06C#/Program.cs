using System;
using System.ComponentModel;
using static Assignment01OOPS06C_.person;

namespace Assignment01OOPS06C_
{
    internal class Program
    {
        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        
            static void Main(string[] args)
            {
                #region part01Q01
                /*Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes
                 * two points as input from the user and calculates the distance between them.*/
                Point p1 = new Point();
                Point p2 = new Point();
                p1.x = p1.GetCoordinateFromUser("cordinate x of point 1");
                p1.y = p1.GetCoordinateFromUser("cordinate y of point 1");
                p2.x = p1.GetCoordinateFromUser("cordinate x of point 2");
                p2.y = p1.GetCoordinateFromUser("cordinate y of point 2");
                Console.WriteLine(CalculateDistance(p1.x, p1.y, p2.x, p2.y));
                #endregion

                #region p01Q02
                /* Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons
                 as input from the user and displays the name and age of the oldest person.*/
                person[] arrayofPersons = new person[3];
                person p = new person();
                
                for (int i = 0;i< arrayofPersons.Length;i++)
                {
                Console.WriteLine("enter your age ");
                p.Age=int.Parse(Console.ReadLine());
                Console.WriteLine("enter your name ");
                p.Name = Console.ReadLine();
                arrayofPersons[i] = p;
                }
                p = arrayofPersons[0];
                for(int i = 0;i<3;i++)
                {
                if (p.Age < arrayofPersons[i].Age)
                    {
                    p=arrayofPersons[i];
                        
                    }
                }
            Console.WriteLine(p.ToString());
            #endregion

            #region part02Q01
            /*1.	Design and implement a Class for the employees in a company:
            Notes:
            •	Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            •	We need to restrict the Gender field to be only M or F [Male or Female] 
            •	Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum.
            •	We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [Use String.Format() Function].
            */
            employee em =new employee(10,"Bilal",security.DBA,35000,new DateTime(2024-10-10),gender.male);
            Console.WriteLine(em.ToString());
            #endregion
        }

    }
}