namespace Assignment01OOPS06C_
{
    internal class Program
    {
        struct employee
        {
            int id;
            int salary;
            string name;

        }
        static void Main(string[] args)
        {
            #region V01
            Point point1 = new Point();
            Console.WriteLine(point1.ToString());
            Point point2 = new Point(5,6);
            Console.WriteLine(point2.ToString());

            #endregion
        }
    }
}
