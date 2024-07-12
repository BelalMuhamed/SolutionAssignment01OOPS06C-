namespace Assignment01OOPS06C_
{
    internal class Program
    {
        static  double CalculateDistance(double x1, double y1, double x2, double y2)
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
            p1.x=p1.GetCoordinateFromUser("cordinate x of point 1");
            p1.y=p1.GetCoordinateFromUser("cordinate y of point 1");
            p2.x = p1.GetCoordinateFromUser("cordinate x of point 2");
            p2.y = p1.GetCoordinateFromUser("cordinate y of point 2");
            Console.WriteLine(CalculateDistance(p1.x, p1.y, p2.x, p2.y));
            #endregion
        }
    }
}
